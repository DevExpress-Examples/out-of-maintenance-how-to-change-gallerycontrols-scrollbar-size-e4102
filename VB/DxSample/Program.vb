Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.UserSkins

Namespace DxSample
	Friend NotInheritable Class Program
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			SkinManager.EnableFormSkins()
			BonusSkins.Register()
			Application.Run(New MainForm())
		End Sub
	End Class
End Namespace
