Imports System
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.UserSkins

Namespace DxSample

    Friend Module Program

        <STAThread>
        Sub Main()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call SkinManager.EnableFormSkins()
            Call BonusSkins.Register()
            Call Application.Run(New MainForm())
        End Sub
    End Module
End Namespace
