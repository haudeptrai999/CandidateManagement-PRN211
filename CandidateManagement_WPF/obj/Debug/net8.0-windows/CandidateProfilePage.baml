   M S B A M L   `   `   `  ����R  NCandidateManagement_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:CandidateManagement_WPFCandidateManagement_WPF  5      2    ,CandidateManagement_WPF.CandidateProfilePage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:CandidateManagement_WPF     5      -   5          N� Title$  CandidateProfilePage��5	      .��5      ��  �� CornerRadius$ 0, 0, 12, 0��6   ���#1f1f1f._�5   
   � .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ CandidateProfileDataGrid��5      $��
0,156,0,10q�6d   
������    RowBackground
 ���� $��0q�6�      AutoGenerateColumns$ False��6�      HeadersVisibility$ Column=�6�      CanUserAddRows$ False��6�      GridLinesVisibility$
 None=�6     
IsReadOnly$
 True��6*  	   	RowHeight$	 80Q�6<  
 � 	Resources
 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value �� 
TargetType*  $System.Windows.Controls.DataGridCell �� Triggers P� Property P� Value)  #System.Windows.Controls.DataGridRow��%0  '        '  &    '  �    �� 5      "  6   .�5      ��  � �� 5      �� 5   "   "  62   .R�5   &   �� ���#525252
�������$��1q�5      ._�5   *   �� #��z��5      $��Center=�5      $��Center=�5      
�������$��SemiBold"�5      5    '   5!   #   5#      5$      �� 5%      "  6   .�5&      ��  � ��
 �����67   �� 5'       � �� 5(      �� 5)   "   "  62   .R�5*   &   �� 
������ 
�������$��1q�6Y   ._�5+   *   �� $��Center=�5,      $��Center=�5-      #��z��5.      #��z��5/      50   '   51   #   53       54      P� 55       �@ 
IsSelected$
 True��6<   . �56   "   ��  � �� �#5252526?   �� 57   "    � ��
 �����6?   58      5:      �� 5;      "  6   5<      5=         Columns 5?      0  *System.Windows.Controls.DataGridTextColumn  5@      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)   -   5        CandidateIdColumn��   Width5  /System.Windows.Controls.DataGridLengthConverter$
 1.5* 5@   p   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6P   �� *CandidateId+6p     5A      $ 	Full Name��6)   -   5        FullNameColumn��$
 2.5* 5A   q    6T   �� *
Fullname+6q     5B      $ 	Birth Day��6)   -   5        BirtDayColumn��$
 1.5* 5B   p    6S   �� *
Birthday+6p   4	  .System.Windows.Controls.DataGridTemplateColumn	  5F      $ Profile Info��6-   $ 1* 6C    	  CellTemplate 5G      �� 5H      .R�5I   "   �� -   5        
 � Tag 5I   F   �� *CandidateId+.��5J   &   �� $��Images/open-info.png��6,   $��30��6J   5K   #   5L      5N        5O      $ Job Posting��6)   -   5        JobPostingColumn��$
 2.5* 5O   {    6X   �� *JobPostingName+6{   	  5Q      $ Actions��6-   $ 1* 6>    5R      �� 5S      .R�5T   "   ��  �� Orientation$ Vertical=�6-   .+�5U   &   �� -   5        $��
0, 0, 0, 5q�5U   -    6A   �� *CandidateId+.��5V   *   �� $��Images/update.png��60   $��30��6K   5W   '   �� 5X   &   -	   5         5X   -   �� *CandidateId+.��5Y   *   �� $��Images/delete.png��60   $��25��6K   5Z   '   5[   #   5\      5^      5`      �� 5a      $��Manage Profile Candidate��6   $��Center=�67   $	��Top=�6T   $	��352��6l   $��45��6x   
�������$��25(�6�   $��Center=�6�   $��SemiBold"�6�   �� 5b      -
   5         ��Name$ btnAdd��5b      $
��Left=�6%   $��624,106,0,0q�6@   $	��Top=�6U   $��39��6m   $��80��6y   .��5c      �� $ 
Horizontal=�6   .+�5d      �� $��Images/add.png��6   $��25��64   $��
0, 0, 5, 0q�6?   �� 5e      $��20(�6    Add63   5f      5g      �� 5h      -   5         ��Name$ 	txtSearch��5h      $
��Left=�6)   $��
10,112,0,0q�6D    �� TextWrapping$
 Wrap=�6X   $	��Top=�6l   $	��147��6�   $��28��6�   �� 5i      -   5        $
��Left=�5i      $��162,112,0,0q�60   $	��Top=�6E   $��28��6]   $��78��6i   .��5j      �� $ 
Horizontal=�6   .+�5k      �� $��Images/search.png��6   $��20��67   $��
0, 0, 5, 0q�6B   �� 5l      $��15(�6    Search66   5m      5n      5o      5p      5s      