        private void butSub020000_03_Click(object sender, EventArgs e)//編輯 群組
        {
            if (txtSub020000_01.Text.Length > 0)
            {
                labSub020000_02.ForeColor = Color.Black;

                int Ans = AuthorizationGroupUI2DB();
                if (Ans == 0)
                {
                    initdgvSub020000_01();

                    initLeftSub020000UI();
                    m_intDB2LeftSub020000_id = -1;
                    LeftSub020000UImode();

                    initdgvSub0200_01();
                    Leave_function();
                }
                else
                {
                    switch (Ans)
                    {
                        case 1:
                            MessageBox.Show(Language.m_StrAuthorizationMsg01, Language.m_StrAuthorizationMsg00, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case 2:
                            MessageBox.Show(Language.m_StrAuthorizationMsg02, Language.m_StrAuthorizationMsg00, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case 3:
                            MessageBox.Show(Language.m_StrAuthorizationMsg03, Language.m_StrAuthorizationMsg00, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                    
                }
            }
            else
            {
                labSub020000_02.ForeColor = Color.Red;
                MessageBox.Show(Language.m_StrbutSub020000_03Msg01, butSub020000_03.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }