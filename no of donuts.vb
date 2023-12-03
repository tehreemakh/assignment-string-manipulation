Imports System

Module Program
    Sub Main()
        'declare variable
        Dim Count As Integer

        'initialize Count to 0
        Count = 0

        'prompt for inputting no of donuts
        Console.WriteLine("enter no of donuts: ")
        Count = Console.ReadLine()

        'condition to output prompt
        If Count < 10 Then
            Console.WriteLine("no of donuts are: " & Count)
        Else
            Console.WriteLine("no of donuts are: many")
        End If




    End Sub
End Module
