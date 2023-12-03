Imports System
Imports System.Runtime.ConstrainedExecution
Imports System.Security.Cryptography.X509Certificates

Module Program
    Sub Main()

        'declaration of strings and chars
        Dim Str1, Str2, Str3 As String
        Dim Char1, Char2, Char3 As Char
        Dim i As Integer
        'initialization
        Str1 = ""
        Str2 = ""
        Str3 = ""
        i = 0

        'output promt to take input of string
        Console.Write("enter a string: ")
        Str1 = Console.ReadLine()

        'variable for first character of string, and the character which will replace.
        Char1 = Left(Str1, 1)
        Char2 = "*"

        'loop starts
        For i = 2 To Len(Str1)
            Char3 = Mid(Str1, i, 1) 'ariable in which each character is stored as the loop continues

            If Char3 <> Char1 Then  'condition, if character is not equal to the first character
                Str2 = Str2 & Char3
            Else Str2 = Str2 & Char2  'character is equal to first character
            End If


        Next

        Str3 = Char1 & Str2   'concatenation

        'output final string with prompt
        Console.WriteLine("final string is: " & Str3)










    End Sub
End Module
