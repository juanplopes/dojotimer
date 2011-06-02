$COMSPEC \/c build\ \"build\"
cd ../juanplopes.github.com
git pull
cp ../dojotimer/build/dojotimer.exe .
git commit -am "new dojotimer"
git push