Public Class SiteHelpers

    ' ' ImageCount() 
    '********************
    '
    ' Returns the image count in an image folder.
    '
    <AllowAnonymous>
    Public Shared Function ImageCount(folder As String, extension As String) As Integer

        Dim Count As Integer = 1
        Try
            If HttpContext.Current.Request.IsLocal Then
                Count = IO.Directory.GetFiles("D:\Projects\Repos\APNazarene\" + folder, "*" + extension).Length()
            Else
                Count = IO.Directory.GetFiles("h:\root\home\mikish-001\www\illustrate\APNazarene\" + folder, "*" + extension).Length()
            End If
        Catch ex As Exception
            Return Count
            'MsgBox("Image Directory Not Found", MsgBoxStyle.Critical)

        End Try

        Return Count

    End Function

    ' Overrides   
    '********************
    '
    ' Additional Class Functions
    '
    Public Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
    Public Overrides Function Equals(obj As Object) As Boolean
        Return MyBase.Equals(obj)
    End Function
    Public Overrides Function GetHashCode() As Integer
        Return MyBase.GetHashCode()
    End Function
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

End Class