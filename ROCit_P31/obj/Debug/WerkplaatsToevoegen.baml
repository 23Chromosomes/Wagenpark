   M S B A M L   `   `   `  ����D  @ROCit_P31, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ROCit_P31	ROCit_P31  5      #    ROCit_P31.WerkplaatsToevoegen   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:ROCit_P31     5      .��5	      � .+�5
   
   �� $��Werkplaats Toevoegen��6   $
��Left=�6/   $��	10,10,0,0q�6J   $	��Top=�6]   $��Trebuchet MS)�6u   
�������6�   �� 5   
   $��Bedrijfsnaam��6   $
��Left=�6'   $��	60,41,0,0q�6B   $	��Top=�6U   $��Trebuchet MS)�6m   
�������6�   �� 5   
   $��Werkplaatsnaam��6   $
��Left=�6)   $��	42,72,0,0q�6D   $	��Top=�6W   $��Trebuchet MS)�6o   
�������6�   �� 5   
   -   5          ��Name$  tbxBedrijfsnaam��5      $
��Left=�6+   $��23��6F   $��
172,53,0,0q�6R    �� TextWrapping$
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $  tbxWerkplaatsnaam��5      $
��Left=�6-   $��24��6H   $��
172,84,0,0q�6T   $
 Wrap=�6h   $�� ��6|   $	��Top=�6�   $	��120��6�   �� 5   
   -   5         ��Name$ btnWerkplaatsToevoegen��5      $��Werkplaats Toevoegen��61   $
��Left=�6P   $��172,113,0,0q�6k   $	��Top=�6�   $	��154��6�   $��31��6�   $��Trebuchet MS)�6�   ���	#FFFF8900
�������
�������$��3q�6-  &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgWerkplaatsen��5      $
��Left=�6+   $	��130��6F   $��
393,53,0,0q�6S   $	��Top=�6g   $	��348��6      AutoGenerateColumns .  $��Trebuchet MS)�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Werkplaatsnummer��6i   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *werkplaatsId+   ClipboardContentBinding 6F   Z� 6i     5      $ Werkplaatsnaam��6k    6%   �� *werkplaatsnaam+ 6H   Z� 6k     5      $ Bedrijfsnaam��6i    6%   �� *bedrijfsnaam+ 6F   Z� 6i   5      5      5      