import { Filesystem, Directory } from '@capacitor/filesystem';

function writeFile(path, data) {
    let ret = Filesystem.writeFile({
        path: path,
        data: data,
        directory: Directory.Documents,
        recursive: true
    })
    return ret;
}

export { writeFile };
