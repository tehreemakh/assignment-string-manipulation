Imports System

Module Program
    Sub Main()
        'declaration of strings
        Dim Str1, Str2, Str3, Str4, Str5, Str6 As String
        'initialization
        Str1 = ""
        Str2 = ""
        Str3 = ""
        Str4 = ""
        Str5 = ""
        Str6 = ""

        'input two strings
        Console.Write("enter first string: ")
        Str1 = Console.ReadLine()
        Console.Write("enter second string: ")
        Str2 = Console.ReadLine()

        Str3 = Mid(Str1, 3, Len(Str1) - 2) 'remove first 2 chars of str1 and insert remaining chars in str3
        Str4 = Mid(Str2, 3, Len(Str2) - 2) 'remove first 2 chars of str2 and insert remaining chars in str4
        Str5 = Left(Str1, 2)     'variable contains first two chars of str1
        Str6 = Left(Str2, 2)     'variable contains first two chars of str2

        Str1 = Str6 & Str3    'add first two char of str2, and remaining chars of str1
        Str2 = Str5 & Str4    'add first two char of str1, and remaining chars of str2

        'output final string
        Console.WriteLine("final string: " & Str1 & " " & Str2)
        Console.ReadLine()










    End Sub
End Module
