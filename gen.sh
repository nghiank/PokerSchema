rm -rf Schema/
flatc --csharp schema.fbs
flatc --java schema.fbs
rm -rf ../GameServer/src/main/java/schema
find schema/ -name "*.java" | cpio -pdm ../GameServer/src/main/java
rm -rf ../Poker/Assets/Scripts/Schema
find schema/ -name "*.cs" | cpio -pdm ../Poker/Assets/Scripts
git add .
