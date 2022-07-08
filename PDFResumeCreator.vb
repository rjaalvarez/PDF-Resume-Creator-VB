Imports System.IO
Imports Newtonsoft.Json
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.draw
Public Class pdfResumeCreatorVB
    Private Sub btnGeneratePDF_Click(sender As Object, e As EventArgs) Handles btnGeneratePDF.Click
        Dim json_pathfile As String = "C:\Users\RJ\source\repos\PDF Resume Creator\PDFResumeCreator.json"
        Dim open_jsonfile As String = File.ReadAllText(json_pathfile)
        Dim outputJson As readJson = JsonConvert.DeserializeObject(Of readJson)(open_jsonfile)
        Dim MyResume As Document = New Document()
        PdfWriter.GetInstance(MyResume, New FileStream("C:\Users\RJ\source\repos\PDF Resume VB\ALVAREZ_REINIERJOHN.pdf", FileMode.Create))
        Dim font_bold As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.HELVETICA.ToString(), 24, iTextSharp.text.Font.BOLD)
        Dim font_medbold As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.HELVETICA.ToString(), 18, iTextSharp.text.Font.BOLD)
        Dim font_italic As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.HELVETICA.ToString(), 12, iTextSharp.text.Font.ITALIC)
        Dim font_smitalic As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.HELVETICA.ToString(), 10, iTextSharp.text.Font.ITALIC)
        Dim font_smbold As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.HELVETICA.ToString(), 12, iTextSharp.text.Font.BOLD)
        Dim image As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(outputJson.image)
        image.ScalePercent(25.0F)
        image.SetAbsolutePosition(MyResume.PageSize.Width - 30.0F - 135.0F, MyResume.PageSize.Height - 30.0F - 150.0F)
        Dim signature As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(outputJson.Signature)
        signature.ScalePercent(30.0F)
        signature.SetAbsolutePosition(MyResume.PageSize.Width - 30.0F - 175.0F, MyResume.PageSize.Height - 30.0F - 740.0F)
        Dim separate As LineSeparator = New LineSeparator(5.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 1)
        Dim name As Paragraph = New Paragraph(outputJson.FullName & vbLf & vbLf, font_bold)
        Dim address As Paragraph = New Paragraph(outputJson.Address & vbLf)
        Dim cityAddress As Paragraph = New Paragraph(outputJson.CityAddress & vbLf)
        Dim phoneNum As Paragraph = New Paragraph(outputJson.PhoneNumber & vbLf)
        Dim emailAdd As Paragraph = New Paragraph(outputJson.EmailAddress & vbLf & vbLf)
        Dim objectiveTitle As Paragraph = New Paragraph(outputJson.ObjectiveTitle & vbLf & vbLf, font_medbold)
        Dim objective As Paragraph = New Paragraph(outputJson.Objective & vbLf & vbLf)
        Dim educTitle As Paragraph = New Paragraph(outputJson.EducationTitle & vbLf & vbLf, font_medbold)
        Dim educHSdate As Paragraph = New Paragraph(outputJson.EducHSDate.ToString().PadRight(50) & outputJson.EducHS, font_smbold)
        Dim Lagro As Paragraph = New Paragraph(outputJson.HSschool1.ToString().PadLeft(93), font_italic)
        Dim Jarmeth As Paragraph = New Paragraph(outputJson.HSschool2.ToString().PadLeft(92) & vbLf & vbLf, font_italic)
        Dim educClgdate As Paragraph = New Paragraph(outputJson.EducClgDate.ToString().PadRight(48) & outputJson.EducClg, font_smbold)
        Dim educClgcourse As Paragraph = New Paragraph(outputJson.ClgCourse.ToString().PadLeft(101), font_italic)
        Dim PUP As Paragraph = New Paragraph(outputJson.ClgSchool.ToString().PadLeft(99), font_italic)
        Dim PUPAddress As Paragraph = New Paragraph(outputJson.ClgAddress.ToString().PadLeft(90) & vbLf & vbLf, font_italic)
        Dim skills As Paragraph = New Paragraph(outputJson.Skills & vbLf & vbLf, font_medbold)
        Dim proglang As Paragraph = New Paragraph(outputJson.ProgLang, font_italic)
        Dim webtech As Paragraph = New Paragraph(outputJson.WebTech, font_italic)
        Dim ide As Paragraph = New Paragraph(outputJson.IDE, font_italic)
        Dim complit As Paragraph = New Paragraph(outputJson.CompLit, font_italic)
        Dim otherskl As Paragraph = New Paragraph(outputJson.OtherSkl & vbLf & vbLf, font_italic)
        Dim footer As Paragraph = New Paragraph(outputJson.Footer & vbLf & vbLf & vbLf, font_smitalic)
        Dim myname As Paragraph = New Paragraph(outputJson.MyName.ToString().PadRight(30), font_italic)
        myname.Alignment = Element.ALIGN_RIGHT
        footer.Alignment = Element.ALIGN_CENTER
        objective.Alignment = Element.ALIGN_JUSTIFIED
        MyResume.Open()
        MyResume.Add(separate)
        MyResume.Add(image)
        MyResume.Add(name)
        MyResume.Add(address)
        MyResume.Add(cityAddress)
        MyResume.Add(phoneNum)
        MyResume.Add(emailAdd)
        MyResume.Add(separate)
        MyResume.Add(objectiveTitle)
        MyResume.Add(objective)
        MyResume.Add(separate)
        MyResume.Add(educTitle)
        MyResume.Add(educHSdate)
        MyResume.Add(Lagro)
        MyResume.Add(Jarmeth)
        MyResume.Add(educClgdate)
        MyResume.Add(educClgcourse)
        MyResume.Add(PUP)
        MyResume.Add(PUPAddress)
        MyResume.Add(separate)
        MyResume.Add(skills)
        MyResume.Add(proglang)
        MyResume.Add(webtech)
        MyResume.Add(ide)
        MyResume.Add(complit)
        MyResume.Add(otherskl)
        MyResume.Add(footer)
        MyResume.Add(myname)
        MyResume.Add(signature)
        MyResume.Close()
        MessageBox.Show("File Created Successfully. Check your destination folder.")
    End Sub

    Public Class readJson
        Public Property FullName As String
        Public Property image As String
        Public Property Address As String
        Public Property CityAddress As String
        Public Property PhoneNumber As String
        Public Property EmailAddress As String
        Public Property ObjectiveTitle As String
        Public Property Objective As String
        Public Property EducationTitle As String
        Public Property EducHSDate As String
        Public Property EducHS As String
        Public Property HSschool1 As String
        Public Property HSschool2 As String
        Public Property EducClg As String
        Public Property EducClgDate As String
        Public Property ClgCourse As String
        Public Property ClgSchool As String
        Public Property ClgAddress As String
        Public Property Skills As String
        Public Property ProgLang As String
        Public Property WebTech As String
        Public Property IDE As String
        Public Property CompLit As String
        Public Property OtherSkl As String
        Public Property Footer As String
        Public Property MyName As String
        Public Property Signature As String
    End Class

End Class
