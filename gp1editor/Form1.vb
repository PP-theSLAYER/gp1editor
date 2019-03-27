Option Explicit On

Imports System
Imports System.Globalization
Imports System.IO
Imports System.Reflection
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Text.RegularExpressions

Imports System.ComponentModel

Imports System.Threading
Imports Microsoft.VisualBasic
Imports System.CodeDom.Compiler

Imports System.CodeDom

Imports System.Runtime.InteropServices



Public Class Form1
    'offsets
    Public sysv As String = "v1.0.7"
    Public version As Integer = 0
    Public Optionflag As Integer = 0

    Public ot1byte As Integer = &H0  'to 0x0f
    Public ot2byte As Integer = &H10  'to 0x1f
    Public speciesbyte As Integer = &H28  'to 0x29
    Public iv1byte As Integer = &H50
    Public iv2byte As Integer = &H54
    Public iv3byte As Integer = &H58
    Public genderbyte As Integer = &H70
    Public alolanflagbyte As Integer = &H72
    Public shinyflagbyte As Integer = &H73
    Public pgomove1byte As Integer = &H74
    Public pgomove2byte As Integer = &H78
    Public geolocationnamebyte As Integer = &H7C 'to 0x60
    Public rawleveldata As Integer = &H30
    Public nicknamebyte As Integer = &H12D  'to 0x20, 00 until 02
    Public datebyte As Integer = &H5C  'to 0x5F, account for endianness
    Public rawcpbyte As Integer = &H2C  'to 0x2D, endianness
    Public geolocationdatabyte As Integer = &H38  'to 0x47 assumingly
    Public weightheigtbyte As Integer = &H48  'to 0x4f ?
    Public weightbyte As Integer = &H4C
    Public heightbyte As Integer = &H48
    Public mythbyte As Integer = &H20

    'other variables
    Public dataraw(&H1B0) As Byte
    Public only_file_name As String = ""
    Public file_name_in As String = ""
    Public file_name_out As String = ""
    Dim directory_path As String = ""
    Public infoReader_in As FileInfo

    Public moveindexkind As String() = {"(none)",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Charged",
"Charged",
"Unused",
"Charged",
"Unused",
"Charged",
"Unused",
"Charged",
"Charged",
"Charged",
"Unused",
"Charged",
"Unused",
"Charged",
"Unused",
"Charged",
"Unused",
"Charged",
"Charged",
"Charged",
"Charged",
"Charged",
"Charged",
"Charged",
"Unused",
"Charged",
"Charged",
"Charged",
"Unused",
"Charged",
"Unused",
"Unused",
"Charged",
"Charged",
"Charged",
"Charged",
"Charged",
"Charged",
"Charged",
"Unused",
"Charged",
"Charged",
"Unused",
"Charged",
"Charged",
"Charged",
"Charged",
"Charged",
"Unused",
"Charged",
"Charged",
"Charged",
"Charged",
"Charged",
"Charged",
"Unused",
"Charged",
"Charged",
"Unused",
"Charged",
"Unused",
"Charged",
"Charged",
"Unused",
"Charged",
"Charged",
"Charged",
"Charged",
"Unused",
"Charged",
"Charged",
"Charged",
"Charged",
"Charged",
"Charged",
"Charged",
"Charged",
"Charged",
"Charged",
"Charged",
"Unused",
"Charged",
"Charged",
"Charged",
"Unused",
"Unused",
"Charged",
"Charged",
"Charged",
"Charged",
"Charged",
"Charged",
"Charged",
"Charged",
"Charged",
"Charged",
"Charged",
"Unused",
"Charged",
"Unused",
"Unused",
"Charged",
"Charged",
"Charged",
"Charged",
"Charged",
"Unused",
"Unused",
"Charged",
"Charged",
"Charged",
"Unused",
"Charged",
"Charged",
"Charged",
"Unused",
"Charged",
"Unused",
"Charged",
"Charged",
"Charged",
"Charged",
"Charged",
"Charged",
"Charged",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Fast",
"Charged",
"Charged",
"Charged",
"Charged",
"Fast",
"Fast",
"Charged",
"Charged",
"Fast",
"Charged",
"Fast",
"Charged",
"Charged",
"Charged",
"Charged",
"Fast",
"Fast",
"Charged",
"Fast",
"Fast",
"Charged",
"Fast",
"Charged",
"Charged",
"Fast",
"Charged",
"Fast",
"Charged",
"Charged",
"Fast",
"Charged",
"Charged",
"Charged",
"Fast",
"Charged",
"Charged",
"Fast",
"Fast",
"Fast",
"Charged",
"Charged",
"Charged",
"Fast",
"Charged",
"Charged",
"Charged",
"Fast",
"Charged",
"Charged",
"Charged",
"Charged",
"Charged",
"Fast",
"Charged",
"Charged",
"Charged",
"Charged",
"Unused",
"Charged",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Charged",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Unused",
"Charged"}





    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        Me.AllowDrop = True

        'move1.DrawMode = DrawMode.OwnerDrawVariable
        'Dim movelength As Integer = Len(moves)
        ' For i = 0 To 415
        'move1.Items.Add(moves(i))
        'Next
        'move1.SelectedIndex = 0
        'Dim ColorName As String
        'For Each ColorName In System.Enum.GetNames(GetType(System.Drawing.KnownColor))
        'move1.Items.Add(Color.FromName(ColorName))
        'Next

        refreshlist()
    End Sub

    Private Sub loadgp_Click(sender As Object, e As EventArgs) Handles loadgp.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.ShowDialog()

        file_name_in = OpenFileDialog1.FileName
        open_file()
    End Sub

    Private Sub Form1_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragDrop
        'run standard loading here
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)

        file_name_in = files(0)
        open_file()


    End Sub
    Private Sub Form1_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Public Sub open_file()
        If file_name_in = "OpenFileDialog1" Then
            Exit Sub
        ElseIf file_name_in = "" Then
            Exit Sub
        End If

        directory_path = Path.GetDirectoryName(file_name_in)
        only_file_name = Path.GetFileName(file_name_in).ToLower()
        Dim file_extension As String = Path.GetExtension(file_name_in).ToLower()

        If only_file_name = "main" Or only_file_name = "main.bak" Then
            MsgBox("This program doesn't load Save files!")
            Exit Sub
        ElseIf file_extension = ".sav" Then
            MsgBox("This program doesn't load Save files!")
            Exit Sub
        End If

        If file_extension <> ".gp1" Then
            MsgBox("Loaded file isn't .gp1. Please load a .gp1 instead.")
            Exit Sub
        End If

        infoReader_in = My.Computer.FileSystem.GetFileInfo(file_name_in)
        If infoReader_in.Length <> &H1B0 Then
            MsgBox("Incorrect file size.")
            Exit Sub
        End If



        Dim fStream As New FileStream(file_name_in, FileMode.Open, FileAccess.Read)
        Dim br As New BinaryReader(fStream)
        br.BaseStream.Position = 0
        For i = 0 To (&H1B0 - 1)
            dataraw(i) = br.ReadByte()
        Next
        fStream.Close()
        fStream.Dispose()
        br.Close()
        br.Dispose()

        loadgp1()
    End Sub
    Public Sub loadgp1()
        listcheck = 1
        'OT name, WC title and WC flavor text
        Dim k As Integer = 0
        Dim textboxloop As Integer = 1
        Dim textbox_value1 As Integer = 0
        Dim textbox_value2 As Integer = 0
        Dim textbox_name As Object = ""
        Dim ottext As String = ""
        Dim test = ""
        While textboxloop < 5
            Select Case textboxloop
                Case 1
                    textbox_value1 = ot1byte
                    textbox_value2 = ot1byte + &HF
                    textbox_name = otnamebox1
                Case 2
                    textbox_value1 = ot2byte
                    textbox_value2 = ot2byte + &HF
                    textbox_name = otnamebox2
                Case 3
                    textbox_value1 = geolocationnamebyte
                    textbox_value2 = geolocationnamebyte + &H60
                    textbox_name = geolocationnamebox
                Case 4
                    textbox_value1 = nicknamebyte
                    textbox_value2 = nicknamebyte + &H1F
                    textbox_name = nicknamebox

            End Select

            ottext = ""
            k = textbox_value1
            For k = (textbox_value1) To (textbox_value2)
                ottext = ottext & System.Convert.ToChar(System.Convert.ToUInt32(Hex(dataraw(k)).ToString().PadLeft(2, "0"), 16))

            Next
            textbox_name.text = ottext
            textboxloop = textboxloop + 1
        End While


        species.SelectedIndex = Convert.ToInt32(Hex(dataraw(speciesbyte + 1)).ToString().PadLeft(2, "0") & Hex(dataraw(speciesbyte)).ToString().PadLeft(2, "0"), 16)

        If dataraw(alolanflagbyte) = 1 Then
            alolanflag.Checked = True
        Else
            alolanflag.Checked = False
        End If

        If dataraw(shinyflagbyte) = 1 Then
            shinyflag.Checked = True
        Else
            shinyflag.Checked = False
        End If

        If dataraw(mythbyte) = 1 Then
            mythflag.Checked = True
        Else
            mythflag.Checked = False
        End If

        iv1.Text = dataraw(iv1byte)
        iv2.Text = dataraw(iv2byte)
        iv3.Text = dataraw(iv3byte)

        rawcp.Text = Convert.ToInt32(Hex(dataraw(rawcpbyte + 1)).ToString().PadLeft(2, "0") & Hex(dataraw(rawcpbyte)).ToString().PadLeft(2, "0"), 16)

        datebox.Text = Convert.ToInt32(Hex(dataraw(datebyte + 3)).ToString().PadLeft(2, "0") & Hex(dataraw(datebyte + 2)).ToString().PadLeft(2, "0") & Hex(dataraw(datebyte + 1)).ToString().PadLeft(2, "0") & Hex(dataraw(datebyte)).ToString().PadLeft(2, "0"), 16)

        Dim outtext As String = ""
        For i = geolocationdatabyte To geolocationdatabyte + &HF
            outtext = outtext & Hex(dataraw(i)).PadLeft(2, "0")
        Next
        outtext = outtext.PadLeft(32, "0")
        geolocationdatabox.Text = outtext

        genderbox.SelectedIndex = dataraw(genderbyte)

        heightbox.Text = ConvertHexToSingle(Hex(dataraw(heightbyte + 3)).ToString().PadLeft(2, "0") & Hex(dataraw(heightbyte + 2)).ToString().PadLeft(2, "0") & Hex(dataraw(heightbyte + 1)).ToString().PadLeft(2, "0") & Hex(dataraw(heightbyte)).ToString().PadLeft(2, "0"))
        weightbox.Text = ConvertHexToSingle(Hex(dataraw(weightbyte + 3)).ToString().PadLeft(2, "0") & Hex(dataraw(weightbyte + 2)).ToString().PadLeft(2, "0") & Hex(dataraw(weightbyte + 1)).ToString().PadLeft(2, "0") & Hex(dataraw(weightbyte)).ToString().PadLeft(2, "0"))

        rawlevel.Text = ConvertHexToSingle(Hex(dataraw(rawleveldata + 3)).ToString().PadLeft(2, "0") & Hex(dataraw(rawleveldata + 2)).ToString().PadLeft(2, "0") & Hex(dataraw(rawleveldata + 1)).ToString().PadLeft(2, "0") & Hex(dataraw(rawleveldata)).ToString().PadLeft(2, "0"))

        flooredlevel.Text = rounddown(rawlevel.Text)

        recalculate()
        'calculatedcp2.Text = cpcalc(Val(rawlevel.Text), Val(iv1.Text), Val(iv2.Text), Val(iv3.Text), Val(species.SelectedIndex), basestats2)
        'calculatedcp1.Text = cpcalc(Val(rawlevel.Text), Val(iv1.Text), Val(iv2.Text), Val(iv3.Text), Val(species.SelectedIndex), basestats1)

        move1.SelectedIndex = Convert.ToInt32(Hex(dataraw(pgomove1byte + 1)).ToString().PadLeft(2, "0") & Hex(dataraw(pgomove1byte)).ToString().PadLeft(2, "0"), 16)
        move2.SelectedIndex = Convert.ToInt32(Hex(dataraw(pgomove2byte + 1)).ToString().PadLeft(2, "0") & Hex(dataraw(pgomove2byte)).ToString().PadLeft(2, "0"), 16)
        listcheck = 0

        refreshlist()
        enableitems()
    End Sub

    Public Function DoubleToHex(d As Double, Optional reverse As Boolean = False, Optional dashseparator As Integer = 0) As String
        Dim bytes As Byte() = BitConverter.GetBytes(d)
        If reverse Then
            Array.Reverse(bytes)
        End If
        Dim hex = BitConverter.ToString(bytes)
        Dim hex4 = ""
        If dashseparator = 2 Then
            Return hex
        End If
        If dashseparator = 4 Then
            hex = hex.Replace("-", "")
            hex = Regex.Replace(hex, ".{4}", "$0-").TrimEnd("-"c)
            Return hex
        End If
        Return hex.Replace("-", "")
    End Function

    Private Function ConvertHexToSingle(ByVal hexValue As String) As Single
        'source: https://weblogs.asp.net/craigg/Hexadecimal-to-Floating-Point-_2800_IEEE-754_2900_
        Try

            Dim iInputIndex As Integer = 0

            Dim iOutputIndex As Integer = 0

            Dim bArray(3) As Byte



            For iInputIndex = 0 To hexValue.Length - 1 Step 2

                bArray(iOutputIndex) = Byte.Parse(hexValue.Chars(iInputIndex) & hexValue.Chars(iInputIndex + 1), Globalization.NumberStyles.HexNumber)

                iOutputIndex += 1

            Next



            Array.Reverse(bArray)



            Return BitConverter.ToSingle(bArray, 0)

        Catch ex As Exception

            Throw New FormatException("The supplied hex value is either empty or in an incorrect format. Use the following format: 00000000", ex)

        End Try



    End Function
    Public Function rounddown(ByVal thisvalue As String)
        thisvalue = Val(thisvalue) * 10
        Dim thisstring As String = ""
        thisstring = thisvalue.ToString.Substring(0, Len(thisvalue.ToString) - 1)

        Return Val(thisstring)

    End Function

    Public Function cpcalc(ByVal nlevel As Double, niv1 As Integer, niv2 As Integer, niv3 As Integer, nspecies As Integer, nspeciestext As String, nset As Object, mode As Integer)
        Dim calcp As Double = 0
        Dim cpadv As Double = 0
        Select Case nlevel
            Case 1
                cpadv = 0.094
            Case 1.5
                cpadv = 0.135137432
            Case 2
                cpadv = 0.16639787
            Case 2.5
                cpadv = 0.192650919
            Case 3
                cpadv = 0.21573247
            Case 3.5
                cpadv = 0.236572661
            Case 4
                cpadv = 0.25572005
            Case 4.5
                cpadv = 0.273530381
            Case 5
                cpadv = 0.29024988
            Case 5.5
                cpadv = 0.306057377
            Case 6
                cpadv = 0.3210876
            Case 6.5
                cpadv = 0.335445036
            Case 7
                cpadv = 0.34921268
            Case 7.5
                cpadv = 0.362457751
            Case 8
                cpadv = 0.37523559
            Case 8.5
                cpadv = 0.387592406
            Case 9
                cpadv = 0.39956728
            Case 9.5
                cpadv = 0.411193551
            Case 10
                cpadv = 0.42250001
            Case 10.5
                cpadv = 0.432926419
            Case 11
                cpadv = 0.44310755
            Case 11.5
                cpadv = 0.4530599578
            Case 12
                cpadv = 0.46279839
            Case 12.5
                cpadv = 0.472336083
            Case 13
                cpadv = 0.48168495
            Case 13.5
                cpadv = 0.4908558
            Case 14
                cpadv = 0.49985844
            Case 14.5
                cpadv = 0.508701765
            Case 15
                cpadv = 0.51739395
            Case 15.5
                cpadv = 0.525942511
            Case 16
                cpadv = 0.53435433
            Case 16.5
                cpadv = 0.542635767
            Case 17
                cpadv = 0.55079269
            Case 17.5
                cpadv = 0.558830576
            Case 18
                cpadv = 0.56675452
            Case 18.5
                cpadv = 0.574569153
            Case 19
                cpadv = 0.58227891
            Case 19.5
                cpadv = 0.589887917
            Case 20
                cpadv = 0.59740001
            Case 20.5
                cpadv = 0.604818814
            Case 21
                cpadv = 0.61215729
            Case 21.5
                cpadv = 0.619399365
            Case 22
                cpadv = 0.62656713
            Case 22.5
                cpadv = 0.633644533
            Case 23
                cpadv = 0.64065295
            Case 23.5
                cpadv = 0.647576426
            Case 24
                cpadv = 0.65443563
            Case 24.5
                cpadv = 0.661214806
            Case 25
                cpadv = 0.667934
            Case 25.5
                cpadv = 0.674577537
            Case 26
                cpadv = 0.68116492
            Case 26.5
                cpadv = 0.687680648
            Case 27
                cpadv = 0.69414365
            Case 27.5
                cpadv = 0.700538673
            Case 28
                cpadv = 0.70688421
            Case 28.5
                cpadv = 0.713164996
            Case 29
                cpadv = 0.71939909
            Case 29.5
                cpadv = 0.725571552
            Case 30
                cpadv = 0.7317
            Case 30.5
                cpadv = 0.734741009
            Case 31
                cpadv = 0.73776948
            Case 31.5
                cpadv = 0.740785574
            Case 32
                cpadv = 0.74378943
            Case 32.5
                cpadv = 0.746781211
            Case 33
                cpadv = 0.74976104
            Case 33.5
                cpadv = 0.752729087
            Case 34
                cpadv = 0.75568551
            Case 34.5
                cpadv = 0.758630378
            Case 35
                cpadv = 0.76156384
            Case 35.5
                cpadv = 0.764486065
            Case 36
                cpadv = 0.76739717
            Case 36.5
                cpadv = 0.770297266
            Case 37
                cpadv = 0.7731865
            Case 37.5
                cpadv = 0.776064962
            Case 38
                cpadv = 0.77893275
            Case 38.5
                cpadv = 0.781790055
            Case 39
                cpadv = 0.78463697
            Case 39.5
                cpadv = 0.787473578
            Case 40
                cpadv = 0.79030001


        End Select

        If nspecies > 807 Then
            nspecies = nspecies - 807
            nset = datatable.basemel
        End If
        If alolanflag.Checked = True Then
            If version = 2 Then
                nspeciestext = "Alolan " & nspeciestext
            Else
                nspecies = alolabasefinder(nspecies)
                nset = datatable.basealola
            End If
        End If

        If Optionflag = 0 Then
            If megaflag.Checked = True Then
                nspeciestext = "Mega " & nspeciestext
            End If
        ElseIf Optionflag = 1 Then
            If megaflag.Checked = True Then
                nspeciestext = "Mega " & nspeciestext & " X"
            End If
            If megaflagy.Checked = True Then
                nspeciestext = "Mega " & nspeciestext & " Y"
            End If
        ElseIf Optionflag = 2 Then
            If megaflag.Checked = True Then
                nspeciestext = "Primal " & nspeciestext
            End If
        End If


        Dim basestam As Integer = 0
        Dim baseatk As Integer = 0
        Dim basedef As Integer = 0
        If mode = 0 Then
            If version = 2 Then
                basestam = datatable.statfinder(nspeciestext)(0)
                baseatk = datatable.statfinder(nspeciestext)(1)
                basedef = datatable.statfinder(nspeciestext)(2)
            Else
                basestam = nset((nspecies - 1) * 3)
                baseatk = nset(((nspecies - 1) * 3) + 1)
                basedef = nset(((nspecies - 1) * 3) + 2)
            End If
        ElseIf mode = 1 Then
            basestam = datatable.statfinder13dec(nspeciestext)(0)
            baseatk = datatable.statfinder13dec(nspeciestext)(1)
            basedef = datatable.statfinder13dec(nspeciestext)(2)
        End If

        calcp = Math.Floor((baseatk + niv2) * ((basedef + niv3) ^ 0.5) * ((basestam + niv1) ^ 0.5) * ((cpadv ^ 2) / 10))

        'calcp = Math.Round(calcp, 0, MidpointRounding.AwayFromZero)
        If calcp < 10 Then
            calcp = 10
        End If
        Return calcp
    End Function

    Public Function alolabasefinder(ByVal nspecies As Integer)
        Dim nnspecies As Integer = 0
        Select Case nspecies
            Case 19
                nnspecies = 1
            Case 20
                nnspecies = 2
            Case 26
                nnspecies = 3
            Case 27
                nnspecies = 4
            Case 28
                nnspecies = 5
            Case 37
                nnspecies = 6
            Case 38
                nnspecies = 7
            Case 50
                nnspecies = 8
            Case 51
                nnspecies = 9
            Case 52
                nnspecies = 10
            Case 53
                nnspecies = 11
            Case 74
                nnspecies = 12
            Case 75
                nnspecies = 13
            Case 76
                nnspecies = 14
            Case 88
                nnspecies = 15
            Case 89
                nnspecies = 16
            Case 103
                nnspecies = 17
            Case 105
                nnspecies = 18
        End Select


        Return nnspecies
    End Function

    Private Sub rawcp_TextChanged(sender As Object, e As EventArgs) Handles rawcp.TextChanged

    End Sub
    Public localedata As New List(Of String)()
    Public localename As New List(Of String)()
    Public listcheck = 0
    Public directory As String = My.Application.Info.DirectoryPath
    Public filePath As String = Path.Combine(Directory, "location.txt")



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        refreshlist()

    End Sub
    Public Sub refreshlist()

        If Not System.IO.File.Exists(filePath) Then
            System.IO.File.Create(filePath).Dispose()
            System.IO.File.WriteAllText(filePath, My.Resources.location)

        End If
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText(filePath)

        Dim nlocaledata As New List(Of String)()
        Dim nfrontslashpos As New List(Of String)()
        Dim nbackslashpos As New List(Of String)()
        Dim nlocalename As New List(Of String)()

        Dim count = 0
        For i = 0 To Len(fileReader) - 1
            If fileReader(i) = "/" Then
                nfrontslashpos.Add(i)
                'nlocaledata.Add(fileReader.Substring(i - 32, 32))
                count += 1
            End If
            If fileReader(i) = "\" Then
                nbackslashpos.Add(i)
                Try
                    nlocaledata.Add(fileReader.Substring(i + 1, 32))
                Catch ex As Exception
                End Try
            End If
        Next

        Dim ncount = 0
        While ncount < count
            Try
                nlocalename.Add(fileReader.Substring(nfrontslashpos(ncount) + 1, nbackslashpos(ncount + 1) - nfrontslashpos(ncount) - 1))
            Catch ex As Exception

                nlocalename.Add(fileReader.Substring(nfrontslashpos(ncount) + 1, Len(fileReader) - nfrontslashpos(ncount) - 1))
            End Try
            '
            ncount += 1
        End While

        'MsgBox(String.Join(Environment.NewLine, localename.ToArray()))
        'MsgBox(String.Join(Environment.NewLine, frontslashpos.ToArray()))
        'MsgBox(String.Join(Environment.NewLine, backslashpos.ToArray()))

        localedata = nlocaledata
        localename = nlocalename
        geolocationnamecbox.DataSource = localename

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles geolocationnamecbox.SelectedIndexChanged
        'MsgBox(String.Join(Environment.NewLine, localename.ToArray()))
        geolocationdatabox2.Text = localedata(geolocationnamecbox.SelectedIndex)
    End Sub

    Private Sub rawlevel_TextChanged(sender As Object, e As EventArgs)
        If Val(rawlevel.Text) > 40 Then
            rawlevel.Text = 40
        End If


        If listcheck = 1 Then
            Exit Sub
        End If
        recalculate()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not System.IO.File.Exists(filePath) Then
            'System.IO.File.Create(filePath).Dispose()
            My.Computer.FileSystem.CopyFile(
    My.Resources.location,
    filePath,
    Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
    Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)

        End If
        Dim fileExists As Boolean = File.Exists(filePath)

        Using sw As StreamWriter = File.AppendText(filePath)
            sw.WriteLine("\" & geolocationdatabox.Text & "/" & geolocationnamebox.Text)
        End Using
        refreshlist()
    End Sub

    Private Sub loadnone_Click(sender As Object, e As EventArgs) Handles loadnone.Click
        Dim infofilename As String = "empty"
        Using br As New BinaryReader(GetResourceStream(infofilename))
            br.BaseStream.Position = 0
            For i = 0 To &H1B0 - 1
                dataraw(i) = br.ReadByte()
            Next
        End Using
        loadgp1()

    End Sub
    Public Shared Function GetResourceStream(ByVal resourceName As String) As MemoryStream

        Dim buffer As Byte() = CType(My.Resources.ResourceManager.GetObject(resourceName), Byte())

        Return New MemoryStream(buffer)

    End Function

    Public Sub unavailablespecies()
        MsgBox("Unavailable Species")
        species.SelectedIndex = 0
        recalculate()
    End Sub

    Private Sub species_SelectedIndexChanged(sender As Object, e As EventArgs) Handles species.SelectedIndexChanged
        Optionflag = 0
        megaflagy.Checked = False
        megaflagy.Visible = False
        megaflagy.Enabled = False
        megaflag.Text = "Mega Flag"
        If version = 2 Then
        Else
            If species.SelectedIndex > 151 Then
                If species.SelectedIndex < 808 Then
                    unavailablespecies()
                    Exit Sub
                End If
                If species.SelectedIndex > 809 Then
                    unavailablespecies()
                    Exit Sub
                End If

            End If
        End If

        Select Case species.SelectedIndex
            Case 19
                alolanpkmn()
            Case 20
                alolanpkmn()
            Case 26
                alolanpkmn()
            Case 27
                alolanpkmn()
            Case 28
                alolanpkmn()
            Case 37
                alolanpkmn()
            Case 38
                alolanpkmn()
            Case 50
                alolanpkmn()
            Case 51
                alolanpkmn()
            Case 52
                alolanpkmn()
            Case 53
                alolanpkmn()
            Case 74
                alolanpkmn()
            Case 75
                alolanpkmn()
            Case 76
                alolanpkmn()
            Case 88
                alolanpkmn()
            Case 89
                alolanpkmn()
            Case 103
                alolanpkmn()
            Case 105
                alolanpkmn()
            Case 3
                megapkm()
            Case 6
                megaxypkm()
            Case 9
                megapkm()
            Case 65
                megapkm()
            Case 94
                megapkm()
            Case 115
                megapkm()
            Case 130
                megapkm()
            Case 142
                megapkm()
            Case 150
                megaxypkm()
            Case 181
                megapkm()
            Case 212
                megapkm()
            Case 214
                megapkm()
            Case 229
                megapkm()
            Case 248
                megapkm()
            Case 257
                megapkm()
            Case 282
                megapkm()
            Case 303
                megapkm()
            Case 308
                megapkm()
            Case 310
                megapkm()
            Case 354
                megapkm()
            Case 359
                megapkm()
            Case 445
                megapkm()
            Case 448
                megapkm()
            Case 460
                megapkm()
            Case 15
                megapkm()
            Case 18
                megapkm()
            Case 80
                megapkm()
            Case 208
                megapkm()
            Case 254
                megapkm()
            Case 260
                megapkm()
            Case 302
                megapkm()
            Case 319
                megapkm()
            Case 323
                megapkm()
            Case 334
                megapkm()
            Case 362
                megapkm()
            Case 373
                megapkm()
            Case 376
                megapkm()
            Case 380
                megapkm()
            Case 381
                megapkm()
            Case 384
                megapkm()
            Case 428
                megapkm()
            Case 475
                megapkm()
            Case 531
                megapkm()
            Case 719
                megapkm()
            Case 383
                primalpkm()
            Case 382
                primalpkm()
            Case Else
                alolanflag.Checked = False
                alolanflag.Enabled = False
                megaflag.Enabled = False
                megaflag.Checked = False
        End Select
        recalculate()
    End Sub

    Public Sub alolanpkmn()
        alolanflag.Enabled = True
        megaflag.Enabled = False
        megaflag.Checked = False
    End Sub
    Public Sub megapkm()
        If version = 2 Then
            Optionflag = 0
            megaflag.Enabled = True
        End If
        alolanflag.Enabled = False
        alolanflag.Checked = False
    End Sub
    Public Sub megaxypkm()
        If version = 2 Then
            Optionflag = 1
            megaflag.Enabled = True
            megaflagy.Visible = True
            megaflagy.Enabled = True
            megaflag.Text = "Mega Flag X"
        End If
        alolanflag.Enabled = False
        alolanflag.Checked = False

    End Sub
    Public Sub primalpkm()
        If version = 2 Then
            Optionflag = 2
            megaflag.Enabled = True
            megaflag.Text = "Primal"
        End If
        alolanflag.Enabled = False
        alolanflag.Checked = False

    End Sub

    Public Sub enableitems()
        otnamebox1.Enabled = True
        species.Enabled = True
        shinyflag.Enabled = True
        mythflag.Enabled = True
        iv1.Enabled = True
        iv2.Enabled = True
        iv3.Enabled = True
        rawcp.Enabled = True
        rawlevel.Enabled = True
        nicknamebox.Enabled = True
        genderbox.Enabled = True
        datebox.Enabled = True
        geolocationnamecbox.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        weightbox.Enabled = True
        heightbox.Enabled = True
        move1.Enabled = True
        move2.Enabled = True
        maxIV.Enabled = True
        minIV.Enabled = True
        cpcalcbutton.Enabled = True
    End Sub

    Private Sub rawlevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rawlevel.SelectedIndexChanged

        If listcheck = 1 Then
            Exit Sub
        End If
        recalculate()

    End Sub

    Public Sub recalculate()
        Try
            calculatedcp3.Text = cpcalc(Val(rawlevel.Text), Val(iv1.Text), Val(iv2.Text), Val(iv3.Text), Val(species.SelectedIndex), species.Text, datatable.basestats3, 0)
            calculatedcp4.Text = cpcalc(Val(rawlevel.Text), Val(iv1.Text), Val(iv2.Text), Val(iv3.Text), Val(species.SelectedIndex), species.Text, datatable.basestats3, 1)
        Catch ex As Exception
        End Try
        flooredlevel.Text = rounddown(rawlevel.Text)

    End Sub

    Private Sub iv1_TextChanged(sender As Object, e As EventArgs) Handles iv1.TextChanged
        If iv1.Text > 15 Then
            iv1.Text = 15
        End If
        recalculate()
    End Sub

    Private Sub iv2_TextChanged(sender As Object, e As EventArgs) Handles iv2.TextChanged
        If iv2.Text > 15 Then
            iv2.Text = 15
        End If
        recalculate()
    End Sub

    Private Sub iv3_TextChanged(sender As Object, e As EventArgs) Handles iv3.TextChanged
        If iv3.Text > 15 Then
            iv3.Text = 15
        End If
        recalculate()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        geolocationnamebox.Text = geolocationnamecbox.Text
        geolocationdatabox.Text = geolocationdatabox2.Text
    End Sub

    Private Sub otnamebox1_TextChanged(sender As Object, e As EventArgs) Handles otnamebox1.TextChanged
        otnamebox2.Text = otnamebox1.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        For i = 0 To &HF
            Try
                dataraw(i + ot1byte) = Asc(otnamebox1.Text.Substring(i, 1))
                dataraw(i + ot2byte) = Asc(otnamebox1.Text.Substring(i, 1))
            Catch ex As Exception
                dataraw(i + ot1byte) = 0
                dataraw(i + ot2byte) = 0
            End Try
        Next

        Dim datehex As String = Hex(datebox.Text).PadLeft(8, "0")
        dataraw(datebyte) = "&H" & datehex.Substring(6, 2)
        dataraw(datebyte + 1) = "&H" & datehex.Substring(4, 2)
        dataraw(datebyte + 2) = "&H" & datehex.Substring(2, 2)
        dataraw(datebyte + 3) = "&H" & datehex.Substring(0, 2)

        Dim specieshex As String = Hex(species.SelectedIndex).PadLeft(4, "0")
        dataraw(speciesbyte) = "&H" & specieshex.Substring(2, 2)
        dataraw(speciesbyte + 1) = "&H" & specieshex.Substring(0, 2)

        dataraw(iv1byte) = iv1.Text
        dataraw(iv2byte) = iv2.Text
        dataraw(iv3byte) = iv3.Text

        Dim cphex As String = Hex(rawcp.Text).PadLeft(4, "0")
        dataraw(rawcpbyte) = "&H" & cphex.Substring(2, 2)
        dataraw(rawcpbyte + 1) = "&H" & cphex.Substring(0, 2)

        Dim vava As Double = rawlevel.Text
        Dim levelhex As String = float2hex(vava)
        levelhex = levelhex.PadLeft(8, "0")
        dataraw(rawleveldata) = "&H" & levelhex.Substring(0, 2)
        dataraw(rawleveldata + 1) = "&H" & levelhex.Substring(2, 2)
        dataraw(rawleveldata + 2) = "&H" & levelhex.Substring(4, 2)
        dataraw(rawleveldata + 3) = "&H" & levelhex.Substring(6, 2)

        For i = &H12D To &H14C
            Try
                dataraw(i) = Asc(nicknamebox.Text.Substring(i - &H12D, 1))
            Catch ex As Exception
                dataraw(i) = 0
            End Try
        Next

        dataraw(genderbyte) = genderbox.SelectedIndex

        If shinyflag.Checked = True Then
            dataraw(shinyflagbyte) = 1
        Else
            dataraw(shinyflagbyte) = 0
        End If

        If alolanflag.Checked = True Then
            dataraw(alolanflagbyte) = 1
        Else
            dataraw(alolanflagbyte) = 0
        End If

        If mythflag.Checked = True Then
            dataraw(mythbyte) = 1
        Else
            dataraw(mythbyte) = 0
        End If

        For i = &H7C To &HDB
            Try
                dataraw(i) = Asc(geolocationnamebox.Text.Substring(i - &H7C, 1))
            Catch ex As Exception
                dataraw(i) = 0
            End Try
        Next

        For i = &H38 To &H47
            Try
                dataraw(i) = "&H" & (geolocationdatabox.Text.Substring((i - &H38) * 2, 2))
            Catch ex As Exception
                dataraw(i) = 0
            End Try

        Next

        Dim hehe As Double = heightbox.Text
        Dim heighthex As String = float2hex(hehe)
        heighthex = heighthex.PadLeft(8, "0")
        dataraw(heightbyte) = "&H" & heighthex.Substring(0, 2)
        dataraw(heightbyte + 1) = "&H" & heighthex.Substring(2, 2)
        dataraw(heightbyte + 2) = "&H" & heighthex.Substring(4, 2)
        dataraw(heightbyte + 3) = "&H" & heighthex.Substring(6, 2)

        Dim wewe As Double = weightbox.Text
        Dim weighthex As String = float2hex(wewe)
        weighthex = weighthex.PadLeft(8, "0")
        dataraw(weightbyte) = "&H" & weighthex.Substring(0, 2)
        dataraw(weightbyte + 1) = "&H" & weighthex.Substring(2, 2)
        dataraw(weightbyte + 2) = "&H" & weighthex.Substring(4, 2)
        dataraw(weightbyte + 3) = "&H" & weighthex.Substring(6, 2)

        Dim move1hex As String = Hex(move1.SelectedIndex).PadLeft(4, "0")
        dataraw(pgomove1byte) = "&H" & move1hex.Substring(2, 2)
        dataraw(pgomove1byte + 1) = "&H" & move1hex.Substring(0, 2)


        Dim move2hex As String = Hex(move2.SelectedIndex).PadLeft(4, "0")
        dataraw(pgomove2byte) = "&H" & move2hex.Substring(2, 2)
        dataraw(pgomove2byte + 1) = "&H" & move2hex.Substring(0, 2)


        saveFD.Title = "Choose Target GP1 File"
        saveFD.Filter = "GP1 Files|*.gp1"
        saveFD.ShowDialog()

        If saveFD.FileName = "" Then
            Exit Sub
        End If

        Dim fs As New IO.FileStream(savefd.filename, IO.FileMode.OpenOrCreate, IO.FileAccess.ReadWrite)
        fs.Write(dataraw, 0, &H1B0)

        fs.Close()
        fs.Dispose()


    End Sub


    Private Shared Function float2hex(ByVal f As Single)
        'adapted from https://www.daniweb.com/programming/software-development/threads/333922/converting-float-to-32bit-hex
        Dim b As Byte() = BitConverter.GetBytes(f)
        Dim sb As StringBuilder = New StringBuilder()

        For Each by As Byte In b
            sb.Append(by.ToString("X"))
        Next

        Return sb.ToString
    End Function

    Private Sub alolanflag_CheckedChanged(sender As Object, e As EventArgs) Handles alolanflag.CheckedChanged
        recalculate()
    End Sub

    Private Sub minIV_Click(sender As Object, e As EventArgs) Handles minIV.Click
        iv1.Text = 0
        iv2.Text = 0
        iv3.Text = 0
    End Sub

    Private Sub maxIV_Click(sender As Object, e As EventArgs) Handles maxIV.Click
        iv1.Text = 15
        iv2.Text = 15
        iv3.Text = 15
    End Sub

    Private Sub cpcalcbutton_CheckedChanged(sender As Object, e As EventArgs) Handles cpcalcbutton.CheckedChanged
        If cpcalcbutton.Checked = True Then
            version = 2
            shinyflag.Enabled = False
            mythflag.Enabled = False
            datebox.Enabled = False
            rawcp.Enabled = False
            flooredlevel.Enabled = False
            nicknamebox.Enabled = False
            genderbox.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            otnamebox1.Enabled = False
            geolocationnamecbox.Enabled = False
            weightbox.Enabled = False
            heightbox.Enabled = False
            Button4.Enabled = False
            loadgp.Enabled = False
            loadnone.Enabled = False
            move1.Enabled = False
            move2.Enabled = False
            megaflag.Enabled = False
            megaflag.Visible = True
            Me.AllowDrop = False

        Else
            version = 0
            shinyflag.Enabled = True
            mythflag.Enabled = True
            datebox.Enabled = True
            rawcp.Enabled = True
            flooredlevel.Enabled = True
            nicknamebox.Enabled = True
            genderbox.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
            otnamebox1.Enabled = True
            geolocationnamecbox.Enabled = True
            weightbox.Enabled = True
            heightbox.Enabled = True
            Button4.Enabled = True
            loadgp.Enabled = True
            loadnone.Enabled = True
            move1.Enabled = True
            move2.Enabled = True
            megaflag.Enabled = False
            megaflag.Visible = False
            Me.AllowDrop = True


        End If
        species.SelectedIndex = 0
        recalculate()
    End Sub

    Private Sub megaflag_CheckedChanged(sender As Object, e As EventArgs) Handles megaflag.CheckedChanged
        If megaflag.Checked = True Then
            megaflagy.Checked = False
        End If
        recalculate()
    End Sub

    Private Sub megaflagy_CheckedChanged(sender As Object, e As EventArgs) Handles megaflagy.CheckedChanged
        If megaflagy.Checked = True Then
            megaflag.Checked = False
        End If
        recalculate()
    End Sub



    Private Sub move1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles move1.SelectedIndexChanged
        move1atkkind.Text = moveindexkind(move1.SelectedIndex)

        If move1atkkind.Text = "Fast" Then
            move1atkkind.ForeColor = Color.Green
        Else
            move1atkkind.ForeColor = Color.Red
        End If
        '   Dim i As Integer = 0
        '
        'If Array.IndexOf(fastattacks, move1.SelectedIndex) = -1 Then
        'move1.BackColor = System.Drawing.Color.White
        'Else
        'move1.BackColor = System.Drawing.Color.LightGreen
        '
        'End If

    End Sub



    Private Sub move2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles move2.SelectedIndexChanged
        move2atkkind.Text = moveindexkind(move2.SelectedIndex)

        If move2atkkind.Text = "Charged" Then
            move2atkkind.ForeColor = Color.Green
        Else
            move2atkkind.ForeColor = Color.Red
        End If
    End Sub
End Class
