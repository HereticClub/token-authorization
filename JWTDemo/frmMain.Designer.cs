namespace JWTDemo
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.gbUserInfo = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbHeader = new System.Windows.Forms.GroupBox();
            this.txtHeader = new System.Windows.Forms.TextBox();
            this.gbPayload = new System.Windows.Forms.GroupBox();
            this.txtPayload = new System.Windows.Forms.TextBox();
            this.gbSecretKey = new System.Windows.Forms.GroupBox();
            this.txtSecretKey = new System.Windows.Forms.TextBox();
            this.gbToken = new System.Windows.Forms.GroupBox();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnParse = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.lblValidateState = new System.Windows.Forms.Label();
            this.txtNewId = new System.Windows.Forms.Button();
            this.gbUserInfo.SuspendLayout();
            this.gbHeader.SuspendLayout();
            this.gbPayload.SuspendLayout();
            this.gbSecretKey.SuspendLayout();
            this.gbToken.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUserInfo
            // 
            this.gbUserInfo.Controls.Add(this.txtNewId);
            this.gbUserInfo.Controls.Add(this.btnClear);
            this.gbUserInfo.Controls.Add(this.lblLastName);
            this.gbUserInfo.Controls.Add(this.lblFirstName);
            this.gbUserInfo.Controls.Add(this.lblEmail);
            this.gbUserInfo.Controls.Add(this.lblId);
            this.gbUserInfo.Controls.Add(this.txtLastName);
            this.gbUserInfo.Controls.Add(this.txtFirstName);
            this.gbUserInfo.Controls.Add(this.txtEmail);
            this.gbUserInfo.Controls.Add(this.txtId);
            this.gbUserInfo.Location = new System.Drawing.Point(12, 12);
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.Size = new System.Drawing.Size(310, 173);
            this.gbUserInfo.TabIndex = 0;
            this.gbUserInfo.TabStop = false;
            this.gbUserInfo.Text = "User Info";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(77, 20);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(146, 21);
            this.txtId.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(77, 47);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(227, 21);
            this.txtEmail.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(77, 74);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(227, 21);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(77, 101);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(227, 21);
            this.txtLastName.TabIndex = 3;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(6, 23);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(17, 12);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Id";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 50);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 12);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "E-mail";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(6, 77);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(65, 12);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(6, 104);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(59, 12);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Last Name";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(77, 128);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbHeader
            // 
            this.gbHeader.Controls.Add(this.txtHeader);
            this.gbHeader.Location = new System.Drawing.Point(328, 12);
            this.gbHeader.Name = "gbHeader";
            this.gbHeader.Size = new System.Drawing.Size(418, 173);
            this.gbHeader.TabIndex = 8;
            this.gbHeader.TabStop = false;
            this.gbHeader.Text = "Header Json";
            // 
            // txtHeader
            // 
            this.txtHeader.Location = new System.Drawing.Point(149, 23);
            this.txtHeader.Multiline = true;
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHeader.Size = new System.Drawing.Size(194, 100);
            this.txtHeader.TabIndex = 0;
            // 
            // gbPayload
            // 
            this.gbPayload.Controls.Add(this.txtPayload);
            this.gbPayload.Location = new System.Drawing.Point(328, 191);
            this.gbPayload.Name = "gbPayload";
            this.gbPayload.Size = new System.Drawing.Size(418, 223);
            this.gbPayload.TabIndex = 9;
            this.gbPayload.TabStop = false;
            this.gbPayload.Text = "Payload Json";
            // 
            // txtPayload
            // 
            this.txtPayload.Location = new System.Drawing.Point(149, 23);
            this.txtPayload.Multiline = true;
            this.txtPayload.Name = "txtPayload";
            this.txtPayload.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPayload.Size = new System.Drawing.Size(194, 100);
            this.txtPayload.TabIndex = 0;
            // 
            // gbSecretKey
            // 
            this.gbSecretKey.Controls.Add(this.txtSecretKey);
            this.gbSecretKey.Location = new System.Drawing.Point(328, 420);
            this.gbSecretKey.Name = "gbSecretKey";
            this.gbSecretKey.Size = new System.Drawing.Size(418, 83);
            this.gbSecretKey.TabIndex = 10;
            this.gbSecretKey.TabStop = false;
            this.gbSecretKey.Text = "Secret Key";
            // 
            // txtSecretKey
            // 
            this.txtSecretKey.BackColor = System.Drawing.Color.Yellow;
            this.txtSecretKey.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSecretKey.Location = new System.Drawing.Point(149, 23);
            this.txtSecretKey.Multiline = true;
            this.txtSecretKey.Name = "txtSecretKey";
            this.txtSecretKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSecretKey.Size = new System.Drawing.Size(194, 39);
            this.txtSecretKey.TabIndex = 0;
            this.txtSecretKey.Text = "YourSecretKey";
            this.txtSecretKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbToken
            // 
            this.gbToken.Controls.Add(this.txtToken);
            this.gbToken.Location = new System.Drawing.Point(12, 236);
            this.gbToken.Name = "gbToken";
            this.gbToken.Size = new System.Drawing.Size(310, 267);
            this.gbToken.TabIndex = 11;
            this.gbToken.TabStop = false;
            this.gbToken.Text = "Token";
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(34, 87);
            this.txtToken.Multiline = true;
            this.txtToken.Name = "txtToken";
            this.txtToken.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtToken.Size = new System.Drawing.Size(194, 100);
            this.txtToken.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 191);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(93, 191);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(75, 23);
            this.btnParse.TabIndex = 13;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(174, 191);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 14;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // lblValidateState
            // 
            this.lblValidateState.AutoSize = true;
            this.lblValidateState.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblValidateState.Location = new System.Drawing.Point(10, 217);
            this.lblValidateState.Name = "lblValidateState";
            this.lblValidateState.Size = new System.Drawing.Size(152, 16);
            this.lblValidateState.TabIndex = 1;
            this.lblValidateState.Text = "Validation State";
            // 
            // txtNewId
            // 
            this.txtNewId.Location = new System.Drawing.Point(229, 18);
            this.txtNewId.Name = "txtNewId";
            this.txtNewId.Size = new System.Drawing.Size(75, 23);
            this.txtNewId.TabIndex = 8;
            this.txtNewId.Text = "New ID";
            this.txtNewId.UseVisualStyleBackColor = true;
            this.txtNewId.Click += new System.EventHandler(this.txtNewId_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 515);
            this.Controls.Add(this.lblValidateState);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.gbToken);
            this.Controls.Add(this.gbSecretKey);
            this.Controls.Add(this.gbPayload);
            this.Controls.Add(this.gbHeader);
            this.Controls.Add(this.gbUserInfo);
            this.Name = "frmMain";
            this.Text = "JWT Demo Program";
            this.gbUserInfo.ResumeLayout(false);
            this.gbUserInfo.PerformLayout();
            this.gbHeader.ResumeLayout(false);
            this.gbHeader.PerformLayout();
            this.gbPayload.ResumeLayout(false);
            this.gbPayload.PerformLayout();
            this.gbSecretKey.ResumeLayout(false);
            this.gbSecretKey.PerformLayout();
            this.gbToken.ResumeLayout(false);
            this.gbToken.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUserInfo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox gbHeader;
        private System.Windows.Forms.TextBox txtHeader;
        private System.Windows.Forms.GroupBox gbPayload;
        private System.Windows.Forms.TextBox txtPayload;
        private System.Windows.Forms.GroupBox gbSecretKey;
        private System.Windows.Forms.TextBox txtSecretKey;
        private System.Windows.Forms.GroupBox gbToken;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label lblValidateState;
        private System.Windows.Forms.Button txtNewId;
    }
}

