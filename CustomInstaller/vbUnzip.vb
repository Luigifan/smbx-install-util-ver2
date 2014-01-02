Imports Shell32

Public Class vbUnzip
    Dim installDir As String = Form1.installDir
    Public doneUnzip As Boolean = False

    
    Public Sub Zip()
        '1) Lets create an empty Zip File .
        'The following data represents an empty zip file .

        Dim startBuffer() As Byte = {80, 75, 5, 6, 0, 0, 0, 0, 0, 0, 0, _
                                     0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        ' Data for an empty zip file .
        FileIO.FileSystem.WriteAllBytes("d:\empty.zip", startBuffer, False)

        'We have successfully made the empty zip file .

        '2) Use the Shell32 to zip your files .
        ' Declare new shell class
        Dim sc As New Shell32.Shell()
        'Declare the folder which contains the files you want to zip .
        Dim input As Shell32.Folder = sc.NameSpace("D:\neededFiles")
        'Declare  your created empty zip file as folder  .
        Dim output As Shell32.Folder = sc.NameSpace("D:\empty.zip")
        'Copy the files into the empty zip file using the CopyHere command .
        output.CopyHere(input.Items, 4)

        
    End Sub
    
    Public Sub UnZip()
        Dim sc As New Shell32.Shell()
        ''UPDATE !!
        'Create directory in which you will unzip your files .
        IO.Directory.CreateDirectory(installDir + "\smbx")
        'Declare the folder where the files will be extracted
        Dim output As Shell32.Folder = sc.NameSpace(installDir + "\smbx")
        'Declare your input zip file as folder  .
        Dim input As Shell32.Folder = sc.NameSpace(installDir + "\smbx.zip")
        'Extract the files from the zip file using the CopyHere command .
        output.CopyHere(input.Items, 256)
        doneUnzip = True
    End Sub

End Class