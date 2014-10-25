''' <summary>
''' Structure holding a RGB value
''' </summary>
''' <param name="r">Red value as 8 bit byte</param>
''' <param name="g">Green value as 8 bit byte</param>
''' <param name="b">Blue value as 8 bit byte</param>
''' <remarks></remarks>
Public Structure colorHolder
    Public r As Byte
    Public g As Byte
    Public b As Byte
End Structure

Public Class colorSelectForm

    Public colorValue As New colorHolder

    Function inverseColor(colorVal As colorHolder) As colorHolder
        Dim result As colorHolder
        result.r = 255 - colorVal.r
        result.g = 255 - colorVal.b
        result.b = 255 - colorVal.b
        Return result
    End Function

    Public Sub update_text(colorVal As colorHolder)
        Me.BackColor = Color.FromArgb(colorVal.r, colorVal.g, colorVal.b)
        Dim invColor As colorHolder = inverseColor(colorVal)
        captionTxt.ForeColor = Color.FromArgb(invColor.r, invColor.g, invColor.b)
        colorInfo.ForeColor = Color.FromArgb(invColor.r, invColor.g, invColor.b)
        hexColor.Text = Color.FromArgb(invColor.r, invColor.g, invColor.b).ToString
    End Sub

    Private Sub colorBar_changed(sender As Object, e As EventArgs) Handles rBar.Scroll, gBar.Scroll, bBar.Scroll

        If sender Is rBar Then
            Me.colorValue.r = rBar.Value
            rNum.Value = Me.colorValue.r
        End If
        If sender Is gBar Then
            Me.colorValue.g = gBar.Value
            gNum.Value = Me.colorValue.g
        End If
        If sender Is bBar Then
            Me.colorValue.b = bBar.Value
            bNum.Value = Me.colorValue.b
        End If

        update_text(colorValue)
    End Sub

    Private Sub colorNum_changed(sender As Object, e As EventArgs) Handles rNum.ValueChanged, gNum.ValueChanged, bNum.ValueChanged
        If sender Is rNum Then
            Me.colorValue.r = rNum.Value
            rBar.Value = Me.colorValue.r
        End If
        If sender Is gNum Then
            Me.colorValue.g = gNum.Value
            gBar.Value = Me.colorValue.g
        End If
        If sender Is bNum Then
            Me.colorValue.b = bNum.Value
            bBar.Value = Me.colorValue.b
        End If

        update_text(colorValue)
    End Sub


End Class
