﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SURAT_TEBUSAN_PETUGAS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SURAT_TEBUSAN_PETUGAS))
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.keteranagan = New System.Windows.Forms.TextBox()
        Me.ktp = New System.Windows.Forms.TextBox()
        Me.np2 = New System.Windows.Forms.TextBox()
        Me.nip = New System.Windows.Forms.TextBox()
        Me.nm1 = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.no = New System.Windows.Forms.Label()
        Me.kembalain = New System.Windows.Forms.Label()
        Me.totaltebusa = New System.Windows.Forms.Label()
        Me.denda = New System.Windows.Forms.Label()
        Me.tanggaltebusan = New System.Windows.Forms.Label()
        Me.kodebarang = New System.Windows.Forms.Label()
        Me.nb = New System.Windows.Forms.Label()
        Me.nn = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.np = New System.Windows.Forms.Label()
        Me.bayar = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderWidth = 2
        Me.RectangleShape1.Location = New System.Drawing.Point(5, 2)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(604, 677)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.LineShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(951, 707)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 5
        Me.LineShape1.X2 = 608
        Me.LineShape1.Y1 = 519
        Me.LineShape1.Y2 = 520
        '
        'LineShape2
        '
        Me.LineShape2.BorderWidth = 2
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 4
        Me.LineShape2.X2 = 610
        Me.LineShape2.Y1 = 91
        Me.LineShape2.Y2 = 91
        '
        'Button1
        '
        Me.Button1.Image = Global.Aplikasi_Pegadaian.My.Resources.Resources.icons8_print_96
        Me.Button1.Location = New System.Drawing.Point(829, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 91)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'keteranagan
        '
        Me.keteranagan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.keteranagan.Enabled = False
        Me.keteranagan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keteranagan.Location = New System.Drawing.Point(231, 442)
        Me.keteranagan.Multiline = True
        Me.keteranagan.Name = "keteranagan"
        Me.keteranagan.Size = New System.Drawing.Size(332, 62)
        Me.keteranagan.TabIndex = 130
        '
        'ktp
        '
        Me.ktp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ktp.Enabled = False
        Me.ktp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ktp.Location = New System.Drawing.Point(32, 648)
        Me.ktp.Name = "ktp"
        Me.ktp.Size = New System.Drawing.Size(242, 18)
        Me.ktp.TabIndex = 129
        Me.ktp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'np2
        '
        Me.np2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.np2.Enabled = False
        Me.np2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.np2.Location = New System.Drawing.Point(321, 624)
        Me.np2.Name = "np2"
        Me.np2.Size = New System.Drawing.Size(242, 18)
        Me.np2.TabIndex = 128
        Me.np2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nip
        '
        Me.nip.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nip.Enabled = False
        Me.nip.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nip.Location = New System.Drawing.Point(321, 648)
        Me.nip.Name = "nip"
        Me.nip.Size = New System.Drawing.Size(242, 18)
        Me.nip.TabIndex = 127
        Me.nip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nm1
        '
        Me.nm1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nm1.Enabled = False
        Me.nm1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nm1.Location = New System.Drawing.Point(32, 624)
        Me.nm1.Name = "nm1"
        Me.nm1.Size = New System.Drawing.Size(242, 18)
        Me.nm1.TabIndex = 126
        Me.nm1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(210, 439)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(14, 21)
        Me.Label31.TabIndex = 125
        Me.Label31.Text = ":"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(210, 405)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(14, 21)
        Me.Label30.TabIndex = 124
        Me.Label30.Text = ":"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(210, 371)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(14, 21)
        Me.Label29.TabIndex = 123
        Me.Label29.Text = ":"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(210, 338)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(14, 21)
        Me.Label28.TabIndex = 122
        Me.Label28.Text = ":"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(210, 304)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(14, 21)
        Me.Label27.TabIndex = 121
        Me.Label27.Text = ":"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(210, 272)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(14, 21)
        Me.Label26.TabIndex = 120
        Me.Label26.Text = ":"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(210, 242)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(14, 21)
        Me.Label25.TabIndex = 119
        Me.Label25.Text = ":"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(210, 212)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(14, 21)
        Me.Label24.TabIndex = 118
        Me.Label24.Text = ":"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(210, 182)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(14, 21)
        Me.Label17.TabIndex = 117
        Me.Label17.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(210, 150)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(14, 21)
        Me.Label15.TabIndex = 116
        Me.Label15.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(210, 117)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 21)
        Me.Label14.TabIndex = 115
        Me.Label14.Text = ":"
        '
        'no
        '
        Me.no.AutoSize = True
        Me.no.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no.ForeColor = System.Drawing.Color.Red
        Me.no.Location = New System.Drawing.Point(227, 117)
        Me.no.Name = "no"
        Me.no.Size = New System.Drawing.Size(0, 21)
        Me.no.TabIndex = 114
        '
        'kembalain
        '
        Me.kembalain.AutoSize = True
        Me.kembalain.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kembalain.Location = New System.Drawing.Point(227, 405)
        Me.kembalain.Name = "kembalain"
        Me.kembalain.Size = New System.Drawing.Size(0, 21)
        Me.kembalain.TabIndex = 113
        '
        'totaltebusa
        '
        Me.totaltebusa.AutoSize = True
        Me.totaltebusa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totaltebusa.Location = New System.Drawing.Point(227, 338)
        Me.totaltebusa.Name = "totaltebusa"
        Me.totaltebusa.Size = New System.Drawing.Size(0, 21)
        Me.totaltebusa.TabIndex = 112
        '
        'denda
        '
        Me.denda.AutoSize = True
        Me.denda.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.denda.Location = New System.Drawing.Point(227, 304)
        Me.denda.Name = "denda"
        Me.denda.Size = New System.Drawing.Size(0, 21)
        Me.denda.TabIndex = 111
        '
        'tanggaltebusan
        '
        Me.tanggaltebusan.AutoSize = True
        Me.tanggaltebusan.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tanggaltebusan.Location = New System.Drawing.Point(227, 272)
        Me.tanggaltebusan.Name = "tanggaltebusan"
        Me.tanggaltebusan.Size = New System.Drawing.Size(0, 21)
        Me.tanggaltebusan.TabIndex = 110
        '
        'kodebarang
        '
        Me.kodebarang.AutoSize = True
        Me.kodebarang.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kodebarang.Location = New System.Drawing.Point(227, 242)
        Me.kodebarang.Name = "kodebarang"
        Me.kodebarang.Size = New System.Drawing.Size(0, 21)
        Me.kodebarang.TabIndex = 109
        '
        'nb
        '
        Me.nb.AutoSize = True
        Me.nb.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nb.Location = New System.Drawing.Point(227, 212)
        Me.nb.Name = "nb"
        Me.nb.Size = New System.Drawing.Size(0, 21)
        Me.nb.TabIndex = 108
        '
        'nn
        '
        Me.nn.AutoSize = True
        Me.nn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nn.Location = New System.Drawing.Point(227, 182)
        Me.nn.Name = "nn"
        Me.nn.Size = New System.Drawing.Size(0, 21)
        Me.nn.TabIndex = 107
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(51, 117)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(109, 21)
        Me.Label23.TabIndex = 106
        Me.Label23.Text = "NO Transaksi"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(404, 525)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 21)
        Me.Label18.TabIndex = 105
        Me.Label18.Text = "Petugas"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(111, 525)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 21)
        Me.Label16.TabIndex = 104
        Me.Label16.Text = "Nasabah"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(51, 439)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 21)
        Me.Label13.TabIndex = 103
        Me.Label13.Text = "Keterangan"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(51, 405)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 21)
        Me.Label12.TabIndex = 102
        Me.Label12.Text = "Kembalian"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(51, 371)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 21)
        Me.Label11.TabIndex = 101
        Me.Label11.Text = "Bayar"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(51, 305)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 21)
        Me.Label10.TabIndex = 100
        Me.Label10.Text = "Total Tebusan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(51, 338)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 21)
        Me.Label9.TabIndex = 99
        Me.Label9.Text = "Denda"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(51, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 21)
        Me.Label8.TabIndex = 98
        Me.Label8.Text = "Tanggal Tebusan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(51, 242)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 21)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "Kode Barang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(51, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 21)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "Nama Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 21)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Nama Nasabah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 21)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "Nama Petugas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(210, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 21)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "JL.A.Wana Takalala"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(177, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 40)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "SURAT TEBUSAN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(399, 40)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "ARR CELL GADAI TAKALALA"
        '
        'np
        '
        Me.np.AutoSize = True
        Me.np.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.np.Location = New System.Drawing.Point(227, 150)
        Me.np.Name = "np"
        Me.np.Size = New System.Drawing.Size(0, 21)
        Me.np.TabIndex = 131
        '
        'bayar
        '
        Me.bayar.AutoSize = True
        Me.bayar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bayar.Location = New System.Drawing.Point(227, 371)
        Me.bayar.Name = "bayar"
        Me.bayar.Size = New System.Drawing.Size(0, 21)
        Me.bayar.TabIndex = 132
        '
        'SURAT_TEBUSAN_PETUGAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(951, 707)
        Me.Controls.Add(Me.bayar)
        Me.Controls.Add(Me.np)
        Me.Controls.Add(Me.keteranagan)
        Me.Controls.Add(Me.ktp)
        Me.Controls.Add(Me.np2)
        Me.Controls.Add(Me.nip)
        Me.Controls.Add(Me.nm1)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.no)
        Me.Controls.Add(Me.kembalain)
        Me.Controls.Add(Me.totaltebusa)
        Me.Controls.Add(Me.denda)
        Me.Controls.Add(Me.tanggaltebusan)
        Me.Controls.Add(Me.kodebarang)
        Me.Controls.Add(Me.nb)
        Me.Controls.Add(Me.nn)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SURAT_TEBUSAN_PETUGAS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SURAT_TEBUSAN_PETUGAS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents keteranagan As System.Windows.Forms.TextBox
    Friend WithEvents ktp As System.Windows.Forms.TextBox
    Friend WithEvents np2 As System.Windows.Forms.TextBox
    Friend WithEvents nip As System.Windows.Forms.TextBox
    Friend WithEvents nm1 As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents no As System.Windows.Forms.Label
    Friend WithEvents kembalain As System.Windows.Forms.Label
    Friend WithEvents totaltebusa As System.Windows.Forms.Label
    Friend WithEvents denda As System.Windows.Forms.Label
    Friend WithEvents tanggaltebusan As System.Windows.Forms.Label
    Friend WithEvents kodebarang As System.Windows.Forms.Label
    Friend WithEvents nb As System.Windows.Forms.Label
    Friend WithEvents nn As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents np As System.Windows.Forms.Label
    Friend WithEvents bayar As System.Windows.Forms.Label
End Class
