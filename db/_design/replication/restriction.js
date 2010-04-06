function(doc, req) {
  if(doc.restricted)
  {
    for(var i=0; i<doc.restricted; i++) {
      if(doc.restricted[i] == req.query.pool_id) {
        return false;
      }
    }
  }
  return true;
}