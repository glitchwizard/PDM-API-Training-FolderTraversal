Imports EPDM.Interop.epdm

Public Class TraversalForm
	Private Sub TraversalForm_Load(ByVal sender As System. _
		Object, ByVal e As System.EventArgs) Handles MyBase. _
		Load

		Dim vault As IEdmVault8 = New EdmVault5
		Dim Views() As EdmViewInfo = {}

		vault.GetVaultViews(Views, False)
		VaultsComboBox.Items.Clear()
		For Each View As EdmViewInfo In Views
			VaultsComboBox.Items.Add(View.mbsVaultName)
		Next
		If VaultsComboBox.Items.Count > 0 Then
			VaultsComboBox.Text = VaultsComboBox.Items(0)
		End If
	End Sub

	Private Sub TraversFilesButton_Click(ByVal sender As _
		System.Object, ByVal e As System.EventArgs) Handles _
		TraversFilesButton.Click

		'Declare and create an instance of IEdmVault5 object
		Dim vault As IEdmVault5 = New EdmVault5()
		'Log into selected vault as the current user
		vault.LoginAuto(VaultsComboBox.Text, Me.Handle.
			ToInt32())

		'Get the IEdmFolder5 object of the root folder
		Dim RootFolder As IEdmFolder5
		RootFolder = vault.RootFolder

		'Get the path of the root folder
		Dim FolderPath As String
		FolderPath = RootFolder.LocalPath

		'Get the name of the root folder from the IEdmObject interface
		Dim FolderName As String
		FolderName = RootFolder.Name

		'Get the IEdmPos object for the first file in the folder
		Dim FilePos As IEdmPos5
		FilePos = RootFolder.GetFirstFilePosition

		'Enumerate the files in the folder
		Dim file As IEdmFile5
		While Not FilePos.IsNull
			file = RootFolder.GetNextFile(FilePos)
			'Get the name of each file from the IEdmOjbect interface
			Dim FileName As String = file.Name
			'Get its checked out status
			Dim CheckedOutStatus As String
			CheckedOutStatus = IIf(file.IsLocked, "", " not")
			Debug.Print(" " + FileName + " -" + CheckedOutStatus + " checked out")
		End While
	End Sub

	Private Sub TraverseFoldersButton_Click(sender As Object, e As EventArgs) Handles TraverseFoldersButton.Click
		'Declare and create an instance of IEdmVault5 object
		Dim vault As IEdmVault5 = New EdmVault5()
		'Log into selected vault as the current user
		vault.LoginAuto(VaultsComboBox.Text, Me.Handle.
			ToInt32())

		'Get the IEdmFolder5 object of the root folder
		Dim RootFolder As IEdmFolder5
		RootFolder = vault.RootFolder

		'Get the path of the root folder
		Dim FolderPath As String
		FolderPath = RootFolder.LocalPath
		Debug.Print(vbCrLf + vbCrLf + FolderPath + vbCrLf)

		'Get the name of the root folder from the IEdmObject interface
		'Dim FolderName As String
		'FolderName = RootFolder.Name
		'Debug.Print("+" + FolderName)

		TraverseFolder(RootFolder, 0)

	End Sub
	Private Sub TraverseFolder(ByVal CurrentFolder As IEdmFolder5, ByVal Level As Integer)

		Dim FolderName As String = CurrentFolder.Name
		Dim Indent As String = New String(" ", Level * 2)

		Debug.Print(Indent + "+" + FolderName)

		'Get the IEdmPos object for the first file in the folder
		Dim FilePos As IEdmPos5
		FilePos = CurrentFolder.GetFirstFilePosition

		'Enumerate the files in the folder
		Dim file As IEdmFile5
		While Not FilePos.IsNull
			file = CurrentFolder.GetNextFile(FilePos)
			'Get the name of each file from the IEdmOjbect interface
			Dim FileName As String = file.Name
			'Get its checked out status
			Dim CheckedOutStatus As String
			CheckedOutStatus = IIf(file.IsLocked, "", " not")
			Debug.Print(Indent + " " + FileName + " -" + CheckedOutStatus + " checked out")
		End While

		'Enumerate the sub-folders in the root folder
		Dim FolderPos As IEdmPos5
		FolderPos = CurrentFolder.GetFirstSubFolderPosition
		While Not FolderPos.IsNull
			Dim SubFolder As IEdmFolder5
			SubFolder = CurrentFolder.GetNextSubFolder(FolderPos)
			'Debug.Print("+" + SubFolder.Name)
			TraverseFolder(SubFolder, Level + 1)
		End While

	End Sub
End Class
