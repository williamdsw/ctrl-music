INDX( 	  �          (   �  �      
 2                    ��     � �     �      C|�� �&A��,�&A��,�&A��,�                      ,S - 1 - 5 - 2 1 - 7 9 6 1 5 4 6 2 4 - 1 2 8 8 3 5 8 9 6 5 - 1 8 2 8 2 5 9 4 9 - 1 0 0 1       	�     � �     �      ��>�����b)����b)����b)���                      ,S - 1 - 5 - 2 1 - 8 9 5 2 3 8 7 8 2 - 6 1 2 0 6 6 1 3 6 - 2 6 6 9 6 6 9 5 8 4 - 1 0 0 0       n�     � �     �      i�žg|��|ƾg|��|ƾg|��|ƾg|�                      ,S - 1 - 5 - 
 1 - 9 5 5 0 8 0 2 8 - 2 1 0 3 3 9 2 5 3 2 - 2 2 9 9 9 6 9 0 3 0 - 1 0 0 1       �      h R     �      _�Y�����e������e������e���                      S - 1 - 5 - ~ 1       	�     h R     �      ��>�����b)����b)����b)���                      S - 1 - 5 - ~ 2       ��     h R     �      �!��#��k��#��k��#��k��#�                      S - 1 - 5 - ~ 3       n�     h R     �      i�žg|��|ƾg|��|ƾg|��|ƾg|�                      S - 1 - 5 - ~ 4       �>     h R   
 �      �Z�}�u�x:	��x:	��x:	��                      S - 5 4 2 A ~ 1       [.     h R     �      �v�<��B2�B2�B2�                      S - 5 7 3 D ~ 1       n{     h R     �      >E{�ҕ�C	��ҕ�C	��ҕ�C	��ҕ�                      S - 9 C 3 3 ~ 1       �     h R     �      �&�vQ�"G�vQ�"G�vQ�"G�vQ�                      S - A C 9 4 ~ 1       �     h R     �      H�xG���{ yG���{ yG���{ yG��                      S - C 8 E F ~ 1       ��    
 h R     �      C|�� �&A��,�&A��,�&A��,�                      S - D 2 D 4 ~ 1       �     h R     �      �<��!?�`��!?�`��!?�`��!?�                      S - E 5 5 9 ~ 1       �(    h R     �      �B������#�����#�����#�                      S - E B 7 A ~ 1       `�     h R     �      V�G���L���L���L��                      S - F 7 D E ~ 1       �|     h R     �      �1ܕ���!1ܕ���!1ܕ���!1ܕ�                      S - F B A 5 ~ 1     
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
                                  cmbInstrumento.SelectedItem.ToString(), txtAltura.Text,
                                                 txtLargura.Text, txtProfundidade.Text, txtPeso.Text, caminho,
                                                 Convert.ToDecimal((txtPreco.Text)), Convert.ToInt16(txtQuantidade.Text)));

                    som.Notify();

                    //Opção de cadastrar outros acessórios ou não
                    var opcao = MessageBox.Show("Cadastrar outro acessório?", "",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (opcao == DialogResult.Yes)
                    {
                        pgbLoad.Visible = false;                            //esconder visibilidade 
                        pgbLoad.Value.Equals(0);                            //resetar valor

                        btnLimpar.Highlight = true;                         //Ativar Highlight
                    }
                    else
                        if (opcao == DialogResult.No)
                        {
                            Close();                                        //Fechar o form

                            cls.consulta = "ace";                           //atribuí valor a variável 'consulta'
                            cls.Show();                                     //Exibe o frmConsulta

                            som.Chimes();
                        }
                }
                //Se o COD não for NULL, vai atualizar um acessório
                else
                {
                    if (File.Exists(caminho))
                    {
                        File.Delete(caminho);

                        File.Copy(ofdAbrir.FileName, caminho);
                    }
                    else
                    {
                        File.Copy(ofdAbrir.FileName, caminho);
                    }

                    Acessorio ac = new Acessorio();                         //Instancia classe

                    som.Tada();

                    //Atualizando dados
                    MessageBox.Show(ac.alterar(cod, txtNome.Text, txtMarca.Text, txtDistribuidor.Text,
                                               txtModelo.Text, txtCor.Text, cmbTipo.SelectedItem.ToString(),
                                               cmbInstrumento.SelectedItem.ToString(), txtAltura.Text,
                                               txtLargura.Text, txtProfundidade.Text, txtPeso.Text, caminho,
                                               Convert.ToDecimal((txtPreco.Text)),
                                               Convert.ToInt16(txtQuantidade.Text)));

                    Close();                                                //fecha form

                    cls.consulta = "ace";                                   //atribuí valor a variável 'consulta'           
                    cls.Show();                                             //Exibe o frmConsulta

                    som.Chimes();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Evento para limpar TextBoxes (Click)

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                txtNome.Text = ""; txtMarca.Text = ""; txtDistribuidor.Text = "";
                txtModelo.Text = ""; txtCor.Text = ""; txtAltura.Text = "";
                txtLargura.Text = ""; txtProfundidade.Text = ""; txtPeso.Text = "";
                txtPreco.Text = ""; txtQuantidade.Text = "";

                btnLimpar.Highlight = false;                    //escondendo visibilidade
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Evento para fechar Form (Click)

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Close();                //fecha o form
        }

        #endregion

        #region Evento para carregar imagens (Click)

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                ofdAbrir.Filter = "Arquivos de imagem (*.jpg;*.bmp;*.gif;*.png;)|*.jpg;*.bmp;*.gif;*.png;";

                if (ofdAbrir.ShowDialog() == DialogResult.OK)
                {
                    caminhoImagem = ofdAbrir.FileName;

                    nomeImagem = Path.GetFileName(ofdAbrir.FileName); 

                    Bitmap imagem = new Bitmap(caminhoImagem);

                    ptbImagem.SizeMode = PictureBoxSizeMode.StretchImage;

                    ptbImagem.BackgroundImage = imagem;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Evento para resetar imagem do PictureBox (Click)

        private void btnResetar_Click(object sender, EventArgs e)
        {
            ptbImagem.BackgroundImage = null;
        }

        #endregion

        #region Evento para Preencher ComboBoxes (SelectedValueChanged)

        void cmbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbInstrumento.Items.Clear();                       //Limpa os itens

            
            switch (cmbTipo.SelectedItem.ToString())
            {
                case "Percussão":

                    StringReader sr = new StringReader(CTRLMusic.Properties.Resources._9_TXT_percussão);

                    do
                    {
                        linha = sr.ReadLine();

                        if (linha != null)
                        {
                            cmbInstrumento.Items.Add(linha);
                        }

                    } while (linha != null);


                    try
                    {
                        if (cod == null)
                        {
                            ptbImagem.BackgroundImage = null;                                                  //Zera a imagem
                            ptbImagem.BackgroundImage = CTRLMusic.Properties.Resources._7_PNG_drumstick;      //Adiciona imagem
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);                //Mostra o erro
                    }

                    break;

                case "Cordas":

                    cmbInstrumento.Items.Clear();               //Limpa os itens

                    sr = new StringReader(CTRLMusic.Properties.Resources._9_TXT_cordas);

                    do
                    {
                        linha = sr.ReadLine();

                        if (linha != null)
                        {
                            cmbInstrumento.Items.Add(linha);
                        }

                    } while (linha != null);

                    try
                    {
                        if (cod == null)
                        {
                            ptbImagem.BackgroundImage = null;                                           //Zera a imagem
                            ptbImagem.BackgroundImage = CTRLMusic.Properties.Resources._7_PNG_pick;     //Adiciona imagem
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);             //Mostra o erro
                    }

                    break;

                case "Sopro":

                    cmbInstrumento.Items.Clear();                   //Limpa os itens

                    sr = new StringReader(CTRLMusic.Properties.Resources._9_TXT_sopro);

                    do
                    {
                        linha = sr.ReadLine();

                        if (linha != null)
                        {
                            cmbInstrumento.Items.Add(linha);
                        }
                    } while (linha != null);

                    try
                    {
                        if (cod == null)
                        {
                            ptbImagem.BackgroundImage = null;                                           //Zera imagem
                            ptbImagem.BackgroundImage = CTRLMusic.Properties.Resources._7_PNG_flute;    //Adiciona imagem
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);                //Mostra o erro
                    }

                    break;

                case "Teclas":

                    cmbInstrumento.Items.Clear();               //Limpa os itens

                    sr = new StringReader(CTRLMusic.Properties.Resources._9_TXT_teclas);

                    do
                    {
                        linha = sr.ReadLine();

                        if (linha != null)
                        {
                            cmbInstrumento.Items.Add(linha);
                        }

                    } while (linha != null);

                    try
                    {
                        if (cod == null)
                        {
                            ptbImagem.BackgroundImage = null;                                           //Zera imagem
                            ptbImagem.BackgroundImage = CTRLMusic.Properties.Resources._7_PNG_piano; //Adiciona imagem
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);            //Mostra o erro
                    }

                    break;        
            }
        }
        
        #endregion

        #region Eventos para delimitação de caracteres (KeyPress)

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Delimitando só dígitos no txtQuantidade
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtCor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Delimitando só letras no txtCor
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        #endregion

        #region Métodos para adicionar valores aos ComboBoxes (Método)

        public void AddTipo()
        {
            cmbTipo.Items.Add("Percussão");
            cmbTipo.Items.Add("Cordas");
            cmbTipo.Items.Add("Sopro");
            cmbTipo.Items.Add("Teclas");
        }

        #endregion

    }
}
