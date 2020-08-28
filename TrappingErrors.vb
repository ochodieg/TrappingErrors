Option Strict On
Option Explicit On
Option Compare Binary

Module TrappingErrors

    Sub Main()
        Dim userinput As String
        Dim userNumber As Integer

        Do

            'While userinput <> "Q" or userinput <> "q"

            Console.WriteLine("type a number and press enter. Enter Q to quit.")
            userinput$ = Console.ReadLine()

            'convert user input from string to integer with "cint" command
            'hover over and press f1 to bring up explenation



            Try

                userNumber% = CInt(userinput$)
                Console.WriteLine(userinput & "+ 5 is:")
                Console.WriteLine(userNumber% + 5)


            Catch ex As InvalidCastException
                'ex is any variable
                'f1 on trycatch 
                ' catch ex as invalid exception
                Console.WriteLine("I asked for a number, numbnuts....you entered:" & userinput)

            End Try

        Loop Until userinput$ = "Q" Or userinput$ = "q"

        'End While

        Console.ReadLine()



    End Sub

End Module
