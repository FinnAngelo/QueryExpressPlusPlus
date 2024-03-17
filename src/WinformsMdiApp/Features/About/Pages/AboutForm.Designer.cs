namespace QueryExpressPlusPlus.WinformsMdiApp.Features.About.Pages;

partial class AboutForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        picLogo = new PictureBox();
        lblProductName = new Label();
        lblVersion = new Label();
        lblCopyright = new Label();
        lblInformationalVersion = new Label();
        txtDescription = new TextBox();
        okButton = new Button();
        ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
        SuspendLayout();
        // 
        // picLogo
        // 
        picLogo.Image = Resources.Qx__130x59px;
        picLogo.Location = new Point(16, 16);
        picLogo.Margin = new Padding(5, 4, 5, 4);
        picLogo.Name = "picLogo";
        picLogo.Size = new Size(130, 58);
        picLogo.SizeMode = PictureBoxSizeMode.CenterImage;
        picLogo.TabIndex = 1;
        picLogo.TabStop = false;
        // 
        // lblProductName
        // 
        lblProductName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblProductName.Location = new Point(160, 16);
        lblProductName.Name = "lblProductName";
        lblProductName.Size = new Size(400, 27);
        lblProductName.TabIndex = 2;
        lblProductName.Text = "Product Name";
        // 
        // lblVersion
        // 
        lblVersion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblVersion.Location = new Point(160, 48);
        lblVersion.Name = "lblVersion";
        lblVersion.Size = new Size(400, 27);
        lblVersion.TabIndex = 3;
        lblVersion.Text = "Version";
        // 
        // lblCopyright
        // 
        lblCopyright.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblCopyright.Location = new Point(160, 112);
        lblCopyright.Name = "lblCopyright";
        lblCopyright.Size = new Size(400, 27);
        lblCopyright.TabIndex = 4;
        lblCopyright.Text = "Copyright";
        // 
        // lblInformationalVersion
        // 
        lblInformationalVersion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblInformationalVersion.Location = new Point(160, 80);
        lblInformationalVersion.Name = "lblInformationalVersion";
        lblInformationalVersion.Size = new Size(400, 27);
        lblInformationalVersion.TabIndex = 5;
        lblInformationalVersion.Text = "Informational Version";
        // 
        // txtDescription
        // 
        txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        txtDescription.Location = new Point(160, 144);
        txtDescription.Margin = new Padding(0);
        txtDescription.Multiline = true;
        txtDescription.Name = "txtDescription";
        txtDescription.ReadOnly = true;
        txtDescription.ScrollBars = ScrollBars.Both;
        txtDescription.Size = new Size(400, 240);
        txtDescription.TabIndex = 6;
        txtDescription.TabStop = false;
        txtDescription.Text = "Description";
        // 
        // okButton
        // 
        okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        okButton.DialogResult = DialogResult.Cancel;
        okButton.Location = new Point(448, 400);
        okButton.Name = "okButton";
        okButton.Size = new Size(112, 32);
        okButton.TabIndex = 7;
        okButton.Text = "&OK";
        // 
        // AboutForm
        // 
        AcceptButton = okButton;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(576, 448);
        Controls.Add(picLogo);
        Controls.Add(lblProductName);
        Controls.Add(lblVersion);
        Controls.Add(lblCopyright);
        Controls.Add(lblInformationalVersion);
        Controls.Add(txtDescription);
        Controls.Add(okButton);
        Name = "AboutForm";
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private System.Windows.Forms.PictureBox picLogo;
    private System.Windows.Forms.Label lblProductName;
    private System.Windows.Forms.Label lblVersion;
    private System.Windows.Forms.Label lblCopyright;
    private System.Windows.Forms.Label lblInformationalVersion;
    private System.Windows.Forms.TextBox txtDescription;
    private System.Windows.Forms.Button okButton;
}
