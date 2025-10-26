Public Class ClassDog
    Implements InterfaceAnimal
    Public Sub Speak() Implements InterfaceAnimal.Speak
        MsgBox("WOOF! WOOF!", MsgBoxStyle.Information, "DOGS")
    End Sub

    Public Sub Tricks() Implements InterfaceAnimal.Tricks
        MsgBox("DOGS ARE MANS' BESTFRIEND", MsgBoxStyle.Information, "DOGS")
    End Sub
End Class
