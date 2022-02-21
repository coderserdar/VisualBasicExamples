Public Class ClasFromDLLLibrary
    Public Function ExampleMethod(type_something As String) As String
        Return "Hello from DLL_library, you typed: " & type_something
    End Function
End Class
