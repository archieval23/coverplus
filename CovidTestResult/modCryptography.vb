Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Security.Cryptography

Module modCryptography
    Private tripleDes As New TripleDESCryptoServiceProvider
    Private md5 As New MD5CryptoServiceProvider
    'Public Function EncrptData(ByVal value As String) As String
    '    Dim EncryptionKey As String = "MAKV2SPBNI99212"
    '    Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(value)
    '    Using encryptor As Aes = Aes.Create()
    '        Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
    '         &H65, &H64, &H76, &H65, &H64, &H65,
    '         &H76})
    '        encryptor.Key = pdb.GetBytes(32)
    '        encryptor.IV = pdb.GetBytes(16)
    '        Using ms As New MemoryStream()
    '            Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
    '                cs.Write(clearBytes, 0, clearBytes.Length)
    '                cs.Close()
    '            End Using
    '            value = Convert.ToBase64String(ms.ToArray())
    '        End Using
    '    End Using
    '    Return value
    'End Function
    Public Function EncrptData(ByVal strToEncrypt As String) As String
        Dim sa As SymmetricAlgorithm = SymmetricAlgorithm.Create("TripleDES")
        sa.Key = Convert.FromBase64String("cPSQAC05GBXzMhRRz7tm8cqg+vHdHyN5")
        sa.IV = Convert.FromBase64String("jIShBJVBfXo=")

        Dim inputByteArray() As Byte = Encoding.ASCII.GetBytes(strToEncrypt)
        Dim mS As MemoryStream = New MemoryStream()

        Dim trans As ICryptoTransform = sa.CreateEncryptor
        Dim buf() As Byte = New Byte(2048) {}
        Dim cs As CryptoStream = New CryptoStream(mS, trans, CryptoStreamMode.Write)
        cs.Write(inputByteArray, 0, inputByteArray.Length)
        cs.FlushFinalBlock()

        Return Convert.ToBase64String(mS.ToArray).ToString
    End Function
    Public Function DecrptData(ByVal cipherText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
         &H65, &H64, &H76, &H65, &H64, &H65,
         &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                    cs.Write(cipherBytes, 0, cipherBytes.Length)
                    cs.Close()
                End Using
                cipherText = Encoding.Unicode.GetString(ms.ToArray())
            End Using
        End Using
        Return cipherText
    End Function
End Module
