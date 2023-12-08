Imports System

Module Program
    Sub Main()
        'declare variables
        Dim Str1 As String
        Dim MaxCount, i, j, Count As Integer
        Dim MaxChar, Char1, Char2 As Char

        'initialize
        Str1 = ""
        MaxCount = 0
        MaxChar = ""
        Count = 0
        i = 0
        j = 0

        'prompt to input string
        Console.Write("enter a string: ")
        Str1 = Console.ReadLine()
        'nested loops.
        For i = 1 To Len(Str1)
            Char1 = Mid(Str1, i, 1)
            Count = 0
            For j = 1 To Len(Str1)
                Char2 = Mid(Str1, j, 1)
                If Char2 = Char1 Then  'condition to check if outer current char is equal to inner current char
                    Count = Count + 1   'increment count by one if condition is true.
                End If
            Next     'inner loop ended

            If Count > MaxCount Then  'condition to find the max count, and character which occurs the most.
                MaxCount = Count
                MaxChar = Char1
            End If



        Next
        'ouput character.
        Console.WriteLine("most occuring character is: " & MaxChar)
        Console.ReadLine()

    End Sub
End Module
