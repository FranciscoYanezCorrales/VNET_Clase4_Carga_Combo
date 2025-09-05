Imports System.Data.OleDb


Public Class Form1
    Dim rutaExcel As String = "C:\Users\francisco.yanez\Mi unidad\IPCHILE (DOCENTE)\3-TALLER DE APLICACIONES PUNTO NET\SEMANA 4\Maestra.xlsx"
    Dim conexion As OleDbConnection
    Dim dtDatos As DataTable

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cadenaConexion As String =
                "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & rutaExcel & ";Extended Properties='Excel 12.0 Xml;HDR=YES';"

            conexion = New OleDbConnection(cadenaConexion)
            conexion.Open()

            Dim consulta As String = "SELECT * FROM [Dotación del Mes$]"
            Dim adaptador As New OleDbDataAdapter(consulta, conexion)
            Dim ds As New DataSet()
            adaptador.Fill(ds, "Datos")
            dtDatos = ds.Tables("Datos")

            For Each fila As DataRow In dtDatos.Rows
                Crut.Items.Add(fila("RUT").ToString())
            Next
            conexion.Close()

        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message)
        End Try
    End Sub

    Private Sub Crut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Crut.SelectedIndexChanged
        Try

            Dim rutSeleccionado As String = Crut.SelectedItem.ToString()
            Dim filas() As DataRow = dtDatos.Select("RUT = '" & rutSeleccionado & "'")

            If filas.Length > 0 Then
                Dim fila As DataRow = filas(0)
                Tnombre.Text = fila("NOMBRE").ToString()
            End If

        Catch ex As Exception
            MessageBox.Show("Error al mostrar datos: " & ex.Message)
        End Try
    End Sub
End Class
