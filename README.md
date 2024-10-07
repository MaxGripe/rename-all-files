![GitHub repo size](https://img.shields.io/github/repo-size/MaxGripe/rename-all-files)
![GitHub License](https://img.shields.io/github/license/MaxGripe/rename-all-files)
![GitHub Created At](https://img.shields.io/github/created-at/MaxGripe/rename-all-files)
![GitHub forks](https://img.shields.io/github/forks/MaxGripe/rename-all-files)
![GitHub Repo stars](https://img.shields.io/github/stars/MaxGripe/rename-all-files)

# RenameAllFiles

Renames multiple files in a directory by replacing a specified search string with a replace string in the file names.

## Usage

To use the utility, run the following command:

```
RenameAllFiles.exe searchString replaceString [CONFIRM]
```

### Parameters

- `searchString`: The string you want to search for in the file names.
- `replaceString`: The string you want to replace the `searchString` with in the file names.
- `CONFIRM` (optional): If you want to execute the renaming process, add this parameter. Without it, the utility will only display the expected changes without actually renaming the files.

### Example

If you want to replace the word "old" with "new" in the file names in the current directory, run the following command:

```
RenameAllFiles.exe old NEW
```

This will display the expected changes in the file names. For example:
```
Old file.txt -> NEW file.txt
Another old file.older -> Another NEW file.NEWer
 ```

If you are satisfied with the changes and want to proceed with renaming the files, add the `CONFIRM` parameter:

```
RenameAllFiles.exe old new CONFIRM
```

This will rename the files as specified.

## Notes

- Search is case-insensitive, so it will match both upper and lower case occurrences of the search string.
- It processes only files in the current directory, not in subdirectories.
