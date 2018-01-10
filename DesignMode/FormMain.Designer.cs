namespace DesignMode
{
    partial class FormMain
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
            this.btFactory = new System.Windows.Forms.Button();
            this.tbOutWindow = new System.Windows.Forms.TextBox();
            this.btAbstractFactory = new System.Windows.Forms.Button();
            this.btSingletonPattern = new System.Windows.Forms.Button();
            this.btBuilderPattern = new System.Windows.Forms.Button();
            this.btPrototypePattern = new System.Windows.Forms.Button();
            this.btAdapterPattern = new System.Windows.Forms.Button();
            this.btBridgePattern = new System.Windows.Forms.Button();
            this.btFilterPattern = new System.Windows.Forms.Button();
            this.btCompositePattern = new System.Windows.Forms.Button();
            this.btDecoratorPattern = new System.Windows.Forms.Button();
            this.btFacadePattern = new System.Windows.Forms.Button();
            this.btFlyweightPattern = new System.Windows.Forms.Button();
            this.btProxyPattern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btFactory
            // 
            this.btFactory.Location = new System.Drawing.Point(12, 12);
            this.btFactory.Name = "btFactory";
            this.btFactory.Size = new System.Drawing.Size(75, 23);
            this.btFactory.TabIndex = 0;
            this.btFactory.Text = "工厂模式";
            this.btFactory.UseVisualStyleBackColor = true;
            this.btFactory.Click += new System.EventHandler(this.btFactory_Click);
            // 
            // tbOutWindow
            // 
            this.tbOutWindow.Location = new System.Drawing.Point(12, 184);
            this.tbOutWindow.Multiline = true;
            this.tbOutWindow.Name = "tbOutWindow";
            this.tbOutWindow.Size = new System.Drawing.Size(534, 203);
            this.tbOutWindow.TabIndex = 1;
            // 
            // btAbstractFactory
            // 
            this.btAbstractFactory.Location = new System.Drawing.Point(93, 12);
            this.btAbstractFactory.Name = "btAbstractFactory";
            this.btAbstractFactory.Size = new System.Drawing.Size(86, 23);
            this.btAbstractFactory.TabIndex = 0;
            this.btAbstractFactory.Text = "抽象工厂模式";
            this.btAbstractFactory.UseVisualStyleBackColor = true;
            this.btAbstractFactory.Click += new System.EventHandler(this.btAbstractFactory_Click);
            // 
            // btSingletonPattern
            // 
            this.btSingletonPattern.Location = new System.Drawing.Point(185, 12);
            this.btSingletonPattern.Name = "btSingletonPattern";
            this.btSingletonPattern.Size = new System.Drawing.Size(75, 23);
            this.btSingletonPattern.TabIndex = 2;
            this.btSingletonPattern.Text = "单例模式";
            this.btSingletonPattern.UseVisualStyleBackColor = true;
            this.btSingletonPattern.Click += new System.EventHandler(this.btSingletonPattern_Click);
            // 
            // btBuilderPattern
            // 
            this.btBuilderPattern.Location = new System.Drawing.Point(266, 12);
            this.btBuilderPattern.Name = "btBuilderPattern";
            this.btBuilderPattern.Size = new System.Drawing.Size(75, 23);
            this.btBuilderPattern.TabIndex = 3;
            this.btBuilderPattern.Text = "建造者模式";
            this.btBuilderPattern.UseVisualStyleBackColor = true;
            this.btBuilderPattern.Click += new System.EventHandler(this.btBuilderPattern_Click);
            // 
            // btPrototypePattern
            // 
            this.btPrototypePattern.Location = new System.Drawing.Point(347, 12);
            this.btPrototypePattern.Name = "btPrototypePattern";
            this.btPrototypePattern.Size = new System.Drawing.Size(75, 23);
            this.btPrototypePattern.TabIndex = 4;
            this.btPrototypePattern.Text = "原型模式";
            this.btPrototypePattern.UseVisualStyleBackColor = true;
            this.btPrototypePattern.Click += new System.EventHandler(this.btPrototypePattern_Click);
            // 
            // btAdapterPattern
            // 
            this.btAdapterPattern.Location = new System.Drawing.Point(428, 12);
            this.btAdapterPattern.Name = "btAdapterPattern";
            this.btAdapterPattern.Size = new System.Drawing.Size(75, 23);
            this.btAdapterPattern.TabIndex = 5;
            this.btAdapterPattern.Text = "适配器模式";
            this.btAdapterPattern.UseVisualStyleBackColor = true;
            this.btAdapterPattern.Click += new System.EventHandler(this.btAdapterPattern_Click);
            // 
            // btBridgePattern
            // 
            this.btBridgePattern.Location = new System.Drawing.Point(12, 59);
            this.btBridgePattern.Name = "btBridgePattern";
            this.btBridgePattern.Size = new System.Drawing.Size(75, 23);
            this.btBridgePattern.TabIndex = 6;
            this.btBridgePattern.Text = "桥接模式";
            this.btBridgePattern.UseVisualStyleBackColor = true;
            this.btBridgePattern.Click += new System.EventHandler(this.btBridgePattern_Click);
            // 
            // btFilterPattern
            // 
            this.btFilterPattern.Location = new System.Drawing.Point(93, 59);
            this.btFilterPattern.Name = "btFilterPattern";
            this.btFilterPattern.Size = new System.Drawing.Size(75, 23);
            this.btFilterPattern.TabIndex = 7;
            this.btFilterPattern.Text = "过滤器模式";
            this.btFilterPattern.UseVisualStyleBackColor = true;
            this.btFilterPattern.Click += new System.EventHandler(this.btFilterPattern_Click);
            // 
            // btCompositePattern
            // 
            this.btCompositePattern.Location = new System.Drawing.Point(185, 59);
            this.btCompositePattern.Name = "btCompositePattern";
            this.btCompositePattern.Size = new System.Drawing.Size(75, 23);
            this.btCompositePattern.TabIndex = 8;
            this.btCompositePattern.Text = "组合模式";
            this.btCompositePattern.UseVisualStyleBackColor = true;
            this.btCompositePattern.Click += new System.EventHandler(this.btCompositePattern_Click);
            // 
            // btDecoratorPattern
            // 
            this.btDecoratorPattern.Location = new System.Drawing.Point(266, 59);
            this.btDecoratorPattern.Name = "btDecoratorPattern";
            this.btDecoratorPattern.Size = new System.Drawing.Size(75, 23);
            this.btDecoratorPattern.TabIndex = 9;
            this.btDecoratorPattern.Text = "装饰器模式";
            this.btDecoratorPattern.UseVisualStyleBackColor = true;
            this.btDecoratorPattern.Click += new System.EventHandler(this.btDecoratorPattern_Click);
            // 
            // btFacadePattern
            // 
            this.btFacadePattern.Location = new System.Drawing.Point(347, 59);
            this.btFacadePattern.Name = "btFacadePattern";
            this.btFacadePattern.Size = new System.Drawing.Size(75, 23);
            this.btFacadePattern.TabIndex = 10;
            this.btFacadePattern.Text = "外观模式";
            this.btFacadePattern.UseVisualStyleBackColor = true;
            this.btFacadePattern.Click += new System.EventHandler(this.btFacadePattern_Click);
            // 
            // btFlyweightPattern
            // 
            this.btFlyweightPattern.Location = new System.Drawing.Point(428, 59);
            this.btFlyweightPattern.Name = "btFlyweightPattern";
            this.btFlyweightPattern.Size = new System.Drawing.Size(75, 23);
            this.btFlyweightPattern.TabIndex = 11;
            this.btFlyweightPattern.Text = "享元模式";
            this.btFlyweightPattern.UseVisualStyleBackColor = true;
            this.btFlyweightPattern.Click += new System.EventHandler(this.btFlyweightPattern_Click);
            // 
            // btProxyPattern
            // 
            this.btProxyPattern.Location = new System.Drawing.Point(12, 101);
            this.btProxyPattern.Name = "btProxyPattern";
            this.btProxyPattern.Size = new System.Drawing.Size(75, 23);
            this.btProxyPattern.TabIndex = 12;
            this.btProxyPattern.Text = "代理模式";
            this.btProxyPattern.UseVisualStyleBackColor = true;
            this.btProxyPattern.Click += new System.EventHandler(this.btProxyPattern_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 399);
            this.Controls.Add(this.btProxyPattern);
            this.Controls.Add(this.btFlyweightPattern);
            this.Controls.Add(this.btFacadePattern);
            this.Controls.Add(this.btDecoratorPattern);
            this.Controls.Add(this.btCompositePattern);
            this.Controls.Add(this.btFilterPattern);
            this.Controls.Add(this.btBridgePattern);
            this.Controls.Add(this.btAdapterPattern);
            this.Controls.Add(this.btPrototypePattern);
            this.Controls.Add(this.btBuilderPattern);
            this.Controls.Add(this.btSingletonPattern);
            this.Controls.Add(this.tbOutWindow);
            this.Controls.Add(this.btAbstractFactory);
            this.Controls.Add(this.btFactory);
            this.Name = "FormMain";
            this.Text = "设计模式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFactory;
        private System.Windows.Forms.TextBox tbOutWindow;
        private System.Windows.Forms.Button btAbstractFactory;
        private System.Windows.Forms.Button btSingletonPattern;
        private System.Windows.Forms.Button btBuilderPattern;
        private System.Windows.Forms.Button btPrototypePattern;
        private System.Windows.Forms.Button btAdapterPattern;
        private System.Windows.Forms.Button btBridgePattern;
        private System.Windows.Forms.Button btFilterPattern;
        private System.Windows.Forms.Button btCompositePattern;
        private System.Windows.Forms.Button btDecoratorPattern;
        private System.Windows.Forms.Button btFacadePattern;
        private System.Windows.Forms.Button btFlyweightPattern;
        private System.Windows.Forms.Button btProxyPattern;
    }
}

