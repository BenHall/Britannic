function(doc, req) {
  if(doc.type == "artist")
    emit(doc.name, doc)
}