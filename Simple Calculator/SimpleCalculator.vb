'Jacob Horsley
'Spring 2025
'RCET 2265
'Simple Calculator
'

Option Explicit On
Option Strict On


Module SimpleCalculator
    Sub Main()

        Dim userInput As String
        Dim firstNumber As Integer
        Dim secondNumber As Decimal

        firstNumber = CInt(userInput)
        secondNumber = CInt(userInput)

        Console.WriteLine("Give me number")


        Console.WriteLine("What willest thou of the numbers: " & vbNewLine _
                          & "1. Addition" & vbNewLine _
                          & "2. Subtract" & vbNewLine _
                          & "3. Multiply" & vbNewLine)

        userinput = Console.ReadLine()


        Console.WriteLine($"Thou hast decidest well...")

        If userinput = "1" Then
            Console.WriteLine("Addicus Numerus!!!")
            Console.WriteLine($"{FirstNumber} + {SecondNumber} = {FirstNumber} + {SecondNumber}")
        ElseIf userinput = "2" Then
            Console.WriteLine("Digitus Subtractorius!!!")
            Console.WriteLine($"{FirstNumber} - {SecondNumber} = {FirstNumber} - {SecondNumber}")
        ElseIf userinput = "3" Then
            Console.WriteLine("MULTIPLICASHITUS!!!")
            Console.WriteLine($"{FirstNumber} * {SecondNumber} = {FirstNumber} * {SecondNumber}")
        Else
            Console.WriteLine("YOU SHALL NOT PASS!!!")
        End If

    End Sub

End Module
