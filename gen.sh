rm -rf Schema/
flatc --csharp schema.fbs
flatc --java schema.fbs
git add .
