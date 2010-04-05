using System;
using OpenRasta.Codecs;
using OpenRasta.TypeSystem;
using OpenRasta.Web;
using OpenRasta.Web.UriDecorators;

namespace Britannic.Web.Infrastructure
{
    public class FormatParameterUriDecorator : IUriDecorator
    {
        readonly ICommunicationContext _context;
        CodecRegistration _selectedCodec;
        private ICodecRepository _codecs;
        private IUriResolver _uris;


        public FormatParameterUriDecorator(ICommunicationContext context, IUriResolver uris, ICodecRepository codecs, ITypeSystem typeSystem)
        {
            _context = context;
            _codecs = codecs;
            _uris = uris;
        }


        public bool Parse(Uri uri, out Uri processedUri)
        {
            processedUri = null;

            UriRegistration uriRegistration = _uris.Match(uri);
            if (uriRegistration == null) 
                return false;

            string format = GetFormat(uri);
            if (string.IsNullOrEmpty(format))
                return false;

            _selectedCodec = _codecs.FindByExtension(uriRegistration.ResourceKey as IType, format);
            if (_selectedCodec == null)
                return false;

            processedUri = uri;
            return true;
        }

        private string GetFormat(Uri uri)
        {
            return GetFormat(uri.Query);
        }


        private string GetFormat(string query)
        {
            string[] parts = query.Split('&');

            foreach (var part in parts)
            {
                if(part.Contains("format="))
                {
                    string[] namePair = part.Split('=');
                    if(namePair.Length == 2)
                        return namePair[1];
                }
            }

            return string.Empty;
        }

        public void Apply()
        { 
            var entity = _context.Response.Entity;
            _context.PipelineData.ResponseCodec = _selectedCodec;
	
            entity.ContentType = _selectedCodec.MediaType;
        }
    }
}