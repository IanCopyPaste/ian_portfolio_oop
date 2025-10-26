Public Class ClassCat
    Implements InterfaceAnimal
    Public Sub Speak() Implements InterfaceAnimal.Speak
        MsgBox("MEOW! MEOW!", MsgBoxStyle.Information, "CATS")
    End Sub

    Public Sub Tricks() Implements InterfaceAnimal.Tricks
        MsgBox("HUMANS ARE CATS' SLAVES", MsgBoxStyle.Information, "CATS")
    End Sub
End Class
