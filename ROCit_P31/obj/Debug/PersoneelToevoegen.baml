   M S B A M L   `   `   `  ����D  @ROCit_P31, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ROCit_P31	ROCit_P31  5      "    ROCit_P31.PersoneelToevoegen   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:ROCit_P31     5      .��5	      � .+�5
   
   �� $��Personeel Toevoegen��6   $
��Left=�6.   $��	10,10,0,0q�6I   $	��Top=�6\   $��Trebuchet MS)�6t   
�������6�   �� 5   
   $��Naam:��6   $
��Left=�6    $��	87,41,0,0q�6;   $	��Top=�6N   $��Trebuchet MS)�6f   
�������6�   �� 5   
   $��Personeelsnummer:��6   $
��Left=�6,   $��	18,72,0,0q�6G   $	��Top=�6Z   $��Trebuchet MS)�6r   
�������6�   �� 5   
   -   5          ��Name$  tbxPersoneelNaam��5      $
��Left=�6,   $��23��6G   $��
172,45,0,0q�6S    �� TextWrapping$
 Wrap=�6g   $	��Top=�6{   $	��120��6�   �� 5   
   -   5        $  tbxPersoneelNummer��5      $
��Left=�6.   $��23��6I   $��
172,74,0,0q�6U   $
 Wrap=�6i   $	��Top=�6}   $	��120��6�   �� 5   
   -   5         ��Name$ btnPersoneelOpslaan��5      $��Personeel Opslaan��6.   $
��Left=�6J   $��151,120,0,0q�6e   $	��Top=�6z   $	��141��6�   $��30��6�   $��Trebuchet MS)�6�   
����������	#FFFF8900
�������$��3q�6$  &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgPersoneel��5      $
��Left=�6(   $��18,168,0,9.6q�6C   $	��214��6Y      AutoGenerateColumns .  $��Trebuchet MS)�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Naam��6a   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *naam+   ClipboardContentBinding 6>   Z� 6a     5      $ Personeelsnummer��6l    6%   �� *personeelsnumer+ 6I   Z� 6l   4  .System.Windows.Controls.DataGridTemplateColumn  5      	   CellTemplate	 5      �� 5      .R�5      �� .+�5   "   �� $ 	btnDelete��6)   -   5        $	��DEL��5   <   6J   5      5      5        5      	 5      �� 5      .R�5       �� .+�5!   "   �� $ 	btnupdate��6)   -   5        $	��upd��5!   <   6J   5"      5#      5%      5'      5)      5*      