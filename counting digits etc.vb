Imports System

Module Program
    Sub Main()
        'declare variables
        Dim Str1 As String
        Dim Char1, Char2 As Char
        Dim AlphaCount, DigitCount, SpecialCount, CharacterCount, i As Integer

        'initialization of variables
        AlphaCount = 0
        DigitCount = 0
        SpecialCount = 0
        CharacterCount = 0
        i = 0
        Str1 = ""

        'input of string and character to be counted
        Console.Write("enter the string: ")
        Str1 = Console.ReadLine()
        Console.Write("enter character to be counted: ")
        Char1 = Console.ReadLine()


        'process 
        For i = 1 To Len(Str1)
            Char2 = Mid(Str1, i, 1)
            ' check for no of alphabets
            If (Asc(Char2) >= 65 And Asc(Char2) <= 90) Or (Asc(Char2) >= 97 And Asc(Char2) <= 122) Then
                AlphaCount = AlphaCount + 1
                ' check for no of digits
            ElseIf Asc(Char2) >= 48 And Asc(Char2) <= 57 Then
                DigitCount = DigitCount + 1
                ' check for no of special characters
            Else
                SpecialCount = SpecialCount + 1
            End If
            'check for no of a specific character
            If Char1 = Char2 Then
                CharacterCount = CharacterCount + 1


            End If

        Next
        'output suitable prompts
        Console.WriteLine("no of specific character to be counted: " & CharacterCount)
        Console.WriteLine("no of alphabets: " & AlphaCount)
        Console.WriteLine("no of digits: " & DigitCount)
        Console.WriteLine("no of special characters: " & SpecialCount)
        Console.ReadLine()

    End Sub
End Module
