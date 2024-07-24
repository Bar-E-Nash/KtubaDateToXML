namespace KtubaDateToXML
{
    partial class KtubaDateForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dayWeekBox = new ComboBox();
            monthBox = new ComboBox();
            yearBox = new ComboBox();
            dayMonthBox = new ComboBox();
            headerLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            actionButton = new Button();
            SuspendLayout();
            // 
            // dayWeekBox
            // 
            dayWeekBox.FormattingEnabled = true;
            dayWeekBox.Items.AddRange(new object[] { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "ששי" });
            dayWeekBox.Location = new Point(52, 155);
            dayWeekBox.Name = "dayWeekBox";
            dayWeekBox.Size = new Size(117, 40);
            dayWeekBox.TabIndex = 0;
            // 
            // monthBox
            // 
            monthBox.FormattingEnabled = true;
            monthBox.Items.AddRange(new object[] { "תשרי", "מרחשוון", "כסלו", "טבת", "שבט", "אדר", "אדר הראשון", "אדר השני", "ניסן", "אייר ", "סיוון", "תמוז", "אב", "אלול" });
            monthBox.Location = new Point(459, 155);
            monthBox.Name = "monthBox";
            monthBox.Size = new Size(138, 40);
            monthBox.TabIndex = 1;
            // 
            // yearBox
            // 
            yearBox.FormattingEnabled = true;
            yearBox.Items.AddRange(new object[] { "תשפ\"ד", "תשפ\"ה", "תשפ\"ו", "תשפ\"ז", "תשפ\"ח", "תשפ\"ט", "תש\"צ", "תשצ\"א", "תשצ\"ב", "תשצ\"ג" });
            yearBox.Location = new Point(678, 155);
            yearBox.Name = "yearBox";
            yearBox.Size = new Size(127, 40);
            yearBox.TabIndex = 2;
            // 
            // dayMonthBox
            // 
            dayMonthBox.FormattingEnabled = true;
            dayMonthBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            dayMonthBox.Location = new Point(265, 155);
            dayMonthBox.Name = "dayMonthBox";
            dayMonthBox.Size = new Size(102, 40);
            dayMonthBox.TabIndex = 3;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Levenim MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 177);
            headerLabel.Location = new Point(293, 23);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(231, 46);
            headerLabel.TabIndex = 4;
            headerLabel.Text = "כתיבת תאריך";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Levenim MT", 13.8F, FontStyle.Bold);
            label1.Location = new Point(41, 120);
            label1.Name = "label1";
            label1.Size = new Size(140, 32);
            label1.TabIndex = 5;
            label1.Text = "היום בשבוע";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Levenim MT", 13.8F, FontStyle.Bold);
            label2.Location = new Point(244, 120);
            label2.Name = "label2";
            label2.Size = new Size(140, 32);
            label2.TabIndex = 6;
            label2.Text = "היום בחודש";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Levenim MT", 13.8F, FontStyle.Bold);
            label3.Location = new Point(489, 120);
            label3.Name = "label3";
            label3.Size = new Size(70, 32);
            label3.TabIndex = 7;
            label3.Text = "חודש";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Levenim MT", 13.8F, FontStyle.Bold);
            label4.Location = new Point(710, 120);
            label4.Name = "label4";
            label4.Size = new Size(59, 32);
            label4.TabIndex = 8;
            label4.Text = "שנה";
            // 
            // actionButton
            // 
            actionButton.Location = new Point(332, 320);
            actionButton.Name = "actionButton";
            actionButton.Size = new Size(166, 81);
            actionButton.TabIndex = 9;
            actionButton.Text = "בצע";
            actionButton.UseVisualStyleBackColor = true;
            actionButton.Click += actionButton_Click;
            // 
            // KtubaDateForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(855, 551);
            Controls.Add(actionButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(headerLabel);
            Controls.Add(dayMonthBox);
            Controls.Add(yearBox);
            Controls.Add(monthBox);
            Controls.Add(dayWeekBox);
            Font = new Font("Levenim MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 177);
            Name = "KtubaDateForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "Ktuba Date";
            Load += KtubaDateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox dayWeekBox;
        private ComboBox monthBox;
        private ComboBox yearBox;
        private ComboBox dayMonthBox;
        private Label headerLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button actionButton;
    }
}
