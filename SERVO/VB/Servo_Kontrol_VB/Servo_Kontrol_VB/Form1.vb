Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToParent()
        BtnBağlantıAç.Enabled = False
        BtnBağlantıAç.BringToFront()

        BtnBağlantıKes.Enabled = False
        BtnBağlantıKes.SendToBack()
        VeriHızı.SelectedItem = "9600"

        Timer1.Start()

    End Sub

    Private Sub BtnComPort_Click(sender As Object, e As EventArgs) Handles BtnComPort.Click
        ComPort.Items.Clear()
        Dim myport As Array
        Dim i As Integer
        myport = IO.Ports.SerialPort.GetPortNames
        ComPort.Items.AddRange(myport)
        i = ComPort.Items.Count
        i = i - i

        Try
            ComPort.SelectedIndex = i

        Catch ex As Exception
            Dim result As DialogResult
            result = MessageBox.Show("Comport Bulunamadı", "Dikkat !!!!", MessageBoxButtons.OK)
            ComPort.Text = ""
            ComPort.Items.Clear()
            Call Form1_Load(Me, e)
        End Try
        BtnBağlantıAç.Enabled = True
        BtnComPort.BringToFront()
        ComPort.DroppedDown = True
    End Sub

    Private Sub BtnBağlantıAç_Click(sender As Object, e As EventArgs) Handles BtnBağlantıAç.Click
        BtnBağlantıAç.Enabled = False
        BtnBağlantıAç.SendToBack()
        SerialPort1.BaudRate = VeriHızı.SelectedItem
        SerialPort1.PortName = ComPort.SelectedItem
        SerialPort1.Open()
        BtnBağlantıKes.Enabled = True
        BtnBağlantıKes.BringToFront()

    End Sub

    Private Sub BtnBağlantıKes_Click(sender As Object, e As EventArgs) Handles BtnBağlantıKes.Click
        BtnBağlantıKes.Enabled = False
        BtnBağlantıKes.SendToBack()

        SerialPort1.Close()
        BtnBağlantıAç.Enabled = True
        BtnBağlantıAç.BringToFront()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        SerialPort1.Write("1")
        Timer2.Stop()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Derece_45.Click
        SerialPort1.Write("2")
        Timer2.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Derece_90.Click
        SerialPort1.Write("3")
        Timer2.Stop()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles derece135.Click
        SerialPort1.Write("4")
        Timer2.Stop()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Derece_180.Click
        SerialPort1.Write("5")
        Timer2.Stop()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Random.Click
        Timer2.Start()

    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        SerialPort1.Write("6")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If SerialPort1.IsOpen Then
            Me.BackColor = Color.Green
            BtnDrc0.Enabled = True
            Derece_45.Enabled = True
            Derece_90.Enabled = True
            derece135.Enabled = True
            Derece_180.Enabled = True
            Random.Enabled = True
        Else
            Me.BackColor = Color.Red
            BtnDrc0.Enabled = False
            Derece_45.Enabled = False
            Derece_90.Enabled = False
            derece135.Enabled = False
            Derece_180.Enabled = False
            Random.Enabled = False
            Timer2.Stop()
        End If
    End Sub

    Private Sub BtnDrc0_Click(sender As Object, e As EventArgs) Handles BtnDrc0.Click
        SerialPort1.Write("1")
    End Sub
End Class
