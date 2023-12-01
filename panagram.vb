Imports System

Module Program
    Sub Main()
      
        'declaration of variables
        Dim Str1, Alpha As String
        Dim Char1 As Char
        Dim i As Integer
        Dim IsPanagram As Boolean
    
        ' initialization
        Str1 = ""
        Alpha = ""

        ' input and processing
        Console.Write("Enter the string: ")
        Str1 = UCase(Console.ReadLine)
        Alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        IsPanagram = True
        For i = 1 To Len(Alpha)
            Char1 = Mid(Alpha, i, 1)
            If InStr(Str1, Char1) = 0 Then
                IsPanagram = False
                Exit For
            End If
        Next
       
    'output suitable prompts
    If IsPanagram Then
            Console.Write("all alphabets are present in the string")
        Else Console.Write("all alpahabets are not present in the string")
        End If









    End Sub




End Module
