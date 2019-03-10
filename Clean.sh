SIZE_PRE=$(du -sB1 | sed -e 's|\s.*||')

echo Cleaning Out Cache
find . -mindepth 2 -type d -name ".vs" -exec rm -rf {} +

echo Cleaning Out Builds
find . -mindepth 2 -type d -name "[Dd]ebug" -exec rm -rf {} +
find . -mindepth 2 -type d -name "[Dd]ebugPublic" -exec rm -rf {} +
find . -mindepth 2 -type d -name "[Rr]elease" -exec rm -rf {} +
find . -mindepth 2 -type d -name "[Rr]eleases" -exec rm -rf {} +
find . -mindepth 2 -type d -name "x64" -exec rm -rf {} +
find . -mindepth 2 -type d -name "x86" -exec rm -rf {} +
find . -mindepth 2 -type d -name "build" -exec rm -rf {} +
find . -mindepth 2 -type d -name "bld" -exec rm -rf {} +
find . -mindepth 2 -type d -name "[Bb]in" -exec rm -rf {} +
find . -mindepth 2 -type d -name "[Oo]bj" -exec rm -rf {} +
find . -mindepth 2 -type d -name "[Dd]ebugPS" -exec rm -rf {} +
find . -mindepth 2 -type d -name "[Rr]eleasePS" -exec rm -rf {} +
find . -mindepth 2 -type d -name "[Tt]est[Rr]esult*" -exec rm -rf {} +
find . -mindepth 2 -type f -name "[Bb]uild[Ll]og.*" -exec rm -rf {} +
find . -mindepth 2 -type f -name "dlldata.c" -exec rm -rf {} +

echo Cleaning Out Software Database Files
find . -mindepth 2 -type f -name "*.sdf" -exec rm -rf {} +

echo Cleaning Out Extra Git Files
find . -mindepth 2 -type f -name ".gitattributes" -exec rm -rf {} +
find . -mindepth 2 -type f -name ".gitignore" -exec rm -rf {} +
find . -mindepth 2 -type d -name ".git" -exec rm -rf {} +

echo Cleaning Out Various Others
find . -mindepth 2 -type f -name "*.tmp" -exec rm -rf {} +
find . -mindepth 2 -type f -name "*.tmp_proj" -exec rm -rf {} +
find . -mindepth 2 -type f -name "*.log" -exec rm -rf {} +

SIZE_PST=$(du -sB1 | sed -e 's|\s.*||')
SIZE_PRC=$((100*$SIZE_PST/$SIZE_PRE))

echo "$SIZE_PRE -> $SIZE_PST"
echo "$SIZE_PRC%"