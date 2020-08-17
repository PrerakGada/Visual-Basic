Imports System.Console
Module StarTriangle
    Sub main()
        WriteLine("Hello Prerak!")

        Dim i As Integer, j As Integer

        Write("Enter the size: ")
        Dim n As Integer = ReadLine()

        For i = 1 To n Step 1

            For j = n To i Step -1
                Write(" ")
            Next

            For j = 1 To i Step 1
                Write("* ")
            Next

            WriteLine()
        Next

        ReadLine()
    End Sub
End Module
