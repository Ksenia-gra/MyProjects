#pragma once

namespace Forms_Lab {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			InitializeComponent();

		}

	protected:
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::TextBox^ textBox1;
	private: System::Windows::Forms::TextBox^ textBox2;
	private: System::Windows::Forms::Label^ label2;
	private: System::Windows::Forms::Panel^ panel1;
	private: System::Windows::Forms::RadioButton^ radioButton3;
	private: System::Windows::Forms::RadioButton^ radioButton2;
	private: System::Windows::Forms::RadioButton^ radioButton1;
	private: System::Windows::Forms::Button^ button1;
	private: System::Windows::Forms::Label^ label3;
	private: System::Windows::Forms::TextBox^ textBox3;
	private: System::Windows::Forms::CheckBox^ checkBox1;
	protected:

	private:

		System::ComponentModel::Container^ components;

#pragma region Windows Form Designer generated code

		void InitializeComponent(void)
		{
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->textBox2 = (gcnew System::Windows::Forms::TextBox());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->panel1 = (gcnew System::Windows::Forms::Panel());
			this->radioButton3 = (gcnew System::Windows::Forms::RadioButton());
			this->radioButton2 = (gcnew System::Windows::Forms::RadioButton());
			this->radioButton1 = (gcnew System::Windows::Forms::RadioButton());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->textBox3 = (gcnew System::Windows::Forms::TextBox());
			this->checkBox1 = (gcnew System::Windows::Forms::CheckBox());
			this->panel1->SuspendLayout();
			this->SuspendLayout();
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Font = (gcnew System::Drawing::Font(L"Tahoma", 9));
			this->label1->Location = System::Drawing::Point(22, 33);
			this->label1->Margin = System::Windows::Forms::Padding(4, 0, 4, 0);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(335, 58);
			this->label1->TabIndex = 0;
			this->label1->Text = L"Ширина\r\nпрямоугольника\r\n";
			// 
			// textBox1
			// 
			this->textBox1->BorderStyle = System::Windows::Forms::BorderStyle::FixedSingle;
			this->textBox1->Font = (gcnew System::Drawing::Font(L"Tahoma", 9));
			this->textBox1->Location = System::Drawing::Point(250, 48);
			this->textBox1->Margin = System::Windows::Forms::Padding(4, 5, 4, 5);
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(228, 36);
			this->textBox1->TabIndex = 1;
			this->textBox1->TextChanged += gcnew System::EventHandler(this, &MyForm::textBox1_TextChanged);
			this->textBox1->KeyPress += gcnew System::Windows::Forms::KeyPressEventHandler(this, &MyForm::textBox1_KeyPress);
			// 
			// textBox2
			// 
			this->textBox2->BorderStyle = System::Windows::Forms::BorderStyle::FixedSingle;
			this->textBox2->Font = (gcnew System::Drawing::Font(L"Tahoma", 9));
			this->textBox2->Location = System::Drawing::Point(250, 141);
			this->textBox2->Margin = System::Windows::Forms::Padding(4, 5, 4, 5);
			this->textBox2->Name = L"textBox2";
			this->textBox2->Size = System::Drawing::Size(228, 36);
			this->textBox2->TabIndex = 2;
			this->textBox2->TextChanged += gcnew System::EventHandler(this, &MyForm::textBox1_TextChanged);
			this->textBox2->KeyPress += gcnew System::Windows::Forms::KeyPressEventHandler(this, &MyForm::textBox2_KeyPress);
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Font = (gcnew System::Drawing::Font(L"Tahoma", 9));
			this->label2->Location = System::Drawing::Point(27, 125);
			this->label2->Margin = System::Windows::Forms::Padding(4, 0, 4, 0);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(335, 58);
			this->label2->TabIndex = 3;
			this->label2->Text = L"Высота\r\nпрямоугольника";
			// 
			// panel1
			// 
			this->panel1->Controls->Add(this->radioButton3);
			this->panel1->Controls->Add(this->radioButton2);
			this->panel1->Controls->Add(this->radioButton1);
			this->panel1->Location = System::Drawing::Point(32, 222);
			this->panel1->Margin = System::Windows::Forms::Padding(4, 5, 4, 5);
			this->panel1->Name = L"panel1";
			this->panel1->Size = System::Drawing::Size(237, 166);
			this->panel1->TabIndex = 4;
			// 
			// radioButton3
			// 
			this->radioButton3->AutoSize = true;
			this->radioButton3->Font = (gcnew System::Drawing::Font(L"Tahoma", 9));
			this->radioButton3->Location = System::Drawing::Point(27, 109);
			this->radioButton3->Margin = System::Windows::Forms::Padding(4, 5, 4, 5);
			this->radioButton3->Name = L"radioButton3";
			this->radioButton3->Size = System::Drawing::Size(262, 33);
			this->radioButton3->TabIndex = 2;
			this->radioButton3->Text = L"10% площади";
			this->radioButton3->UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this->radioButton2->AutoSize = true;
			this->radioButton2->Font = (gcnew System::Drawing::Font(L"Tahoma", 9));
			this->radioButton2->Location = System::Drawing::Point(27, 64);
			this->radioButton2->Margin = System::Windows::Forms::Padding(4, 5, 4, 5);
			this->radioButton2->Name = L"radioButton2";
			this->radioButton2->Size = System::Drawing::Size(228, 33);
			this->radioButton2->TabIndex = 1;
			this->radioButton2->Text = L"Периметр";
			this->radioButton2->UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this->radioButton1->AutoSize = true;
			this->radioButton1->Font = (gcnew System::Drawing::Font(L"Tahoma", 9));
			this->radioButton1->Location = System::Drawing::Point(27, 16);
			this->radioButton1->Margin = System::Windows::Forms::Padding(4, 5, 4, 5);
			this->radioButton1->Name = L"radioButton1";
			this->radioButton1->Size = System::Drawing::Size(205, 33);
			this->radioButton1->TabIndex = 0;
			this->radioButton1->Text = L"Площадь";
			this->radioButton1->UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this->button1->Enabled = false;
			this->button1->Font = (gcnew System::Drawing::Font(L"Tahoma", 9));
			this->button1->Location = System::Drawing::Point(441, 383);
			this->button1->Margin = System::Windows::Forms::Padding(4, 5, 4, 5);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(154, 53);
			this->button1->TabIndex = 5;
			this->button1->Text = L"Вычислить";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &MyForm::button1_Click);
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(462, 222);
			this->label3->Margin = System::Windows::Forms::Padding(4, 0, 4, 0);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(116, 25);
			this->label3->TabIndex = 6;
			this->label3->Text = L"Значение";
			// 
			// textBox3
			// 
			this->textBox3->BackColor = System::Drawing::Color::White;
			this->textBox3->Font = (gcnew System::Drawing::Font(L"Tahoma", 9));
			this->textBox3->Location = System::Drawing::Point(360, 267);
			this->textBox3->Margin = System::Windows::Forms::Padding(4, 5, 4, 5);
			this->textBox3->Name = L"textBox3";
			this->textBox3->ReadOnly = true;
			this->textBox3->Size = System::Drawing::Size(314, 36);
			this->textBox3->TabIndex = 7;
			// 
			// checkBox1
			// 
			this->checkBox1->AutoSize = true;
			this->checkBox1->Location = System::Drawing::Point(58, 444);
			this->checkBox1->Margin = System::Windows::Forms::Padding(4, 5, 4, 5);
			this->checkBox1->Name = L"checkBox1";
			this->checkBox1->Size = System::Drawing::Size(245, 29);
			this->checkBox1->TabIndex = 8;
			this->checkBox1->Text = L"Удвоенное значение";
			this->checkBox1->UseVisualStyleBackColor = true;
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(12, 25);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(694, 516);
			this->Controls->Add(this->checkBox1);
			this->Controls->Add(this->textBox3);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->button1);
			this->Controls->Add(this->panel1);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->textBox2);
			this->Controls->Add(this->textBox1);
			this->Controls->Add(this->label1);
			this->Margin = System::Windows::Forms::Padding(4, 5, 4, 5);
			this->Name = L"MyForm";
			this->Text = L"Площадь и периметр";
			this->Load += gcnew System::EventHandler(this, &MyForm::MyForm_Load);
			this->panel1->ResumeLayout(false);
			this->panel1->PerformLayout();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion

	private: System::Void button1_Click(System::Object^ sender, System::EventArgs^ e)
	{
		double width = Convert::ToDouble(textBox1->Text);
		double height = Convert::ToDouble(textBox2->Text);
		double result;
		if (width <= 0 || height <= 0)
		{
			result = 0;
		}
		if (radioButton2->Checked && result!=0)
		{
			result = width * 2 + height * 2;
		}
		else if(result != 0)
		{
			result = width * height;
			if (radioButton3->Checked)
				result *= 0.1;
		}
		if (checkBox1->Checked && result != 0)
		{
			result *= 2;
		}
		if(result!=0)
			textBox3->Text = Convert::ToString(result);
		else
			textBox3->Text = "Не существует";
	}

	private: System::Void textBox1_TextChanged(System::Object^ sender, System::EventArgs^ e)
	{
		textBox3->Text = "";
		if (textBox1->Text->Length == 0 || textBox2->Text->Length == 0)
		{
			button1->Enabled = 0;
		}
		else
			button1->Enabled = 1;
	}

	private: System::Void textBox1_KeyPress(System::Object^ sender, System::Windows::Forms::KeyPressEventArgs^ e)
	{
		if (e->KeyChar >= '0' && e->KeyChar <= '9')
			return;
		if (e->KeyChar == '.')
			e->KeyChar = ',';
		if (e->KeyChar == ',')
		{
			if (textBox1->Text->IndexOf(',') != -1 ||
				textBox1->Text->Length == 0)
			{
				e->Handled = 1;
			}
			return;
		}
		if (Char::IsControl(e->KeyChar))
		{
			if (e->KeyChar == (char)Keys::Enter)
			{
				textBox2->Focus();
			}
			return;
		}
		e->Handled = 1;
	}

	private: System::Void textBox2_KeyPress(System::Object^ sender, System::Windows::Forms::KeyPressEventArgs^ e)
	{
		if (e->KeyChar >= '0' && e->KeyChar <= '9')
			return;
		if (e->KeyChar == '.')
			e->KeyChar = ',';
		if (e->KeyChar == ',')
		{
			if (textBox2->Text->IndexOf(',') != -1 ||
				textBox2->Text->Length == 0)
			{
				e->Handled = 1;
			}
			return;
		}

		if (Char::IsControl(e->KeyChar))
		{
			if (e->KeyChar == (char)Keys::Enter)
			{
				button1->Focus();
			}
			return;
		}
		e->Handled = 1;
	}


	private: System::Void MyForm_Load(System::Object^ sender, System::EventArgs^ e) {
	}
};
}
