   M S B A M L   `   `   `  ����D  @ROCit_P31, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ROCit_P31	ROCit_P31  5      !    ROCit_P31.OnderhoudsbeurtUC   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:ROCit_P31     5      .��5	      � .+�5
   
   �� $��Onderhoudsbeurt��6   $
��Left=�6*   $��	10,10,0,0q�6E   $	��Top=�6X   $��Trebuchet MS)�6p   
�������6�   �� 5   
   $��
Beurtnaam:��6   $
��Left=�6%   $��	21,55,0,0q�6@   $	��Top=�6S   $��Trebuchet MS)�6k   
�������6�   �� 5   
   $��Prijs:��6   $
��Left=�6!   $��	56,86,0,0q�6<   $	��Top=�6O   $��Trebuchet MS)�6g   
�������6�   �� 5   
   $��Omschrijving:��6   $
��Left=�6(   $��
10,117,0,0q�6C   $	��Top=�6W   $��Trebuchet MS)�6o   
�������6�   �� 5   
   $��Auto:��6   $
��Left=�6    $��
43,267,0,0q�6;   $	��Top=�6O   $��Trebuchet MS)�6g   
�������6�   �� 5   
   -   5          ��Name$  tbxbeurtnaam��5      $
��Left=�6(   $��23��6C   $��
101,61,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��193��6�   �� 5   
   -   5        $  tbxprijs��5      $
��Left=�6$   $��23��6?   $��
101,89,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��134��6�   6�   �� 5   
   -   5        $  tbxomschrijving��5      $
��Left=�6+   $��99��6F   $��101,126,0,0q�6R   $
 Wrap=�6g    �� AcceptsReturn . " �� VerticalScrollBarVisibility$ Visible=�6�   $	��Top=�6�   $	��221��6�   �� 5   
   -   5         ��Name$ cbxauto��5      $
��Left=�6$    �� SelectedValuePath$ autoId��6?   $��101,270,0,0q�6Z   $	��Top=�6o   $	��120��6�    �� DisplayMemberPath$ kenteken��6�   �� 5   
   -   5         ��Name$ btnOpslaanBeurt��5      $��Opslaan��6*   $
��Left=�6<   $��101,351,0,0q�6W   $	��Top=�6l   $	��221��6�   $��32��6�   $��Trebuchet MS)�6�   
����������	#FFFF8900
�������$��3q�6  &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	dgBeurten��5      $��327,43,10,21.6q�6&   	   AutoGenerateColumns	 .  $��Trebuchet MS)�6Z   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Naam��6f   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	beurtnaam+   ClipboardContentBinding 6C   Z� 6f     5      $ Prijs��6c    6%   �� *kosten+ 6@   Z� 6c     5      $ Uitvoerdatum��6i    6%   �� *uitvoerdatum+ 6F   Z� 6i     5      $
 Auto��6j    6%   �� *auto.kenteken+ 6G   Z� 6j     5      $ 
Werkplaats��6u    6%   �� *werkplaat.werkplaatsnaam+ 6R   Z� 6u     5      $ Werkplaats Bedrijf��6s    6%   �� *werkplaat.bedrijfsnaam+ 6P   Z� 6s     5      $ Omschrijving��6i    6%   �� *omschrijving+ 6F   Z� 6i   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5       �� $ btnVerwijder��6%   -   5        $��Verwijderen��5    ;   6Q   5"      5&        5'       5(      �� 5)      .R�5*      �� $ btnWijzigBeurt��6%   -   5        $��Wijzig��5*   =   6N   5+      5-      50      �� 51   
   $��Datum:��6   $
��Left=�6!   $��
33,236,0,0q�6<   $	��Top=�6P   $��Trebuchet MS)�6h   
�������6�   (  "System.Windows.Controls.DatePicker  52   
   -	   5          Name$ dpUitvoerdatum��52      $
��Left=�6-   $��101,240,0,0q�6H   $	��Top=�6]    J� RenderTransformOrigin$ 0.039,0.625&�6�   $	��120��6�   $��22��6�   �� 53   
   $��Werkplaats:��6   $
��Left=�6&   $��
11,298,0,0q�6A   $	��Top=�6U   $��Trebuchet MS)�6m   
�������6�   �� 54   
   -
   5        $ cbxWerkplaats��54      $
��Left=�6*   $��101,300,0,0q�6E   $	��Top=�6Z   $	��120��6r   $ werkplaatsId��6~   $ werkplaatsnaam��6�   56      57      