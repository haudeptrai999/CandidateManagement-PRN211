   M S B A M L   `   `   `  ����R  NCandidateManagement_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:CandidateManagement_WPFCandidateManagement_WPF  5   	   -    'CandidateManagement_WPF.CanidateProfile   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:CandidateManagement_WPF     5   	   -   5          � Title$  CanidateProfile��5   	   $	��560��6!   $	��800��6.   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��27* �6   �� 5      $��4* �6    � ColumnDefinitions 5   
   �� 5      �� 5      $	��49* �6   .+�5   
   �� $��CANIDATE PROFILE MANAGER��6   $
��Left=�63   $��
291,29,0,0q�6N   $	��Top=�6b   $��33��6z   $	��186��6�   $
��Bold"�6�   $��1��6�   �� 5   
   $��Canidate ID��6   $
��Left=�6&   $��
103,72,0,0q�6A   $	��Top=�6U   $��1��6m   �� 5   
   $��FullName��6   $
��Left=�6#   $��103,117,0,0q�6>   $	��Top=�6S   $��1��6k   �� 5   
   $��Birthday��6   $
��Left=�6#   $��	103,0,0,0q�6>   $��Center=�6Q    J� RenderTransformOrigin$ 0.332,1.673&�6l   $��1��6�   �� 5   
   $��Description��6   $
��Left=�6&   $��371,117,0,0q�6A   $	��Top=�6V   $ 0.928,0.117&�6n   $��1��6�   �� 5   
   $��JobPosting ID��6   $
��Left=�6(   $��
371,72,0,0q�6C   $	��Top=�6W   $ 0.492,0.495&�6o   $��1��6�   �� 5   
   $��ImageURL��6   $
��Left=�6#   $��
99,160,0,0q�6>   $	��Top=�6R   $��1��6j   �� 5   
   -   5         ��Name$ txtCanidateID��5      $
��Left=�6)   $��
186,76,0,0q�6D    �� TextWrapping$
 Wrap=�6X   $��TextBox��6l   $	��Top=�6{   $	��120��6�   $��1��6�   �� 5   
   -   5        $ txtFullName��5      $
��Left=�6'   $��186,125,0,0q�6B   $
 Wrap=�6W   $��TextBox��6k   $	��Top=�6z   $	��120��6�   $��1��6�   �� 5   
   -   5        $ txtProfileUrl��5      $
��Left=�6)   $��186,170,0,0q�6D   $
 Wrap=�6Y   $��TextBox��6m   $	��Top=�6|   $	��120��6�   $��1��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
date_birth��5      $
��Left=�6)   $��	186,0,0,0q�6D   $��Center=�6W   $	��120��6r   $ 0.545,-0.465&�6~   $��1��6�   �� 5   
   -   5         ��Name$ 	cmbPostID��5      $
��Left=�6&   $��
478,76,0,0q�6A   $	��Top=�6U   $	��129��6m   $��1��6y   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtg_CandidateProfile��5      $��26,255,154,60q�6\   $��1��6s   $��2��6�   6�   �� 5   
   -   5        	 ��Name$	 btnAdd��5      $	��Add��6!   $
��Left=�6/   $��	26,25,0,0q�6J   $	��Top=�6]   $��29��6u   $��65��6�   $ 0.535,2.801&�6�   $��1��6�   $��1��6�   �� 5    
   -	   5        $��Update��5       $
��Left=�6"   $��
161,25,0,0q�6=   $	��Top=�6Q   $��29��6i   $��64��6u   $��1��6�   $��1��6�   6�   �� 5!   
   -
   5        $��Delete��5!      $
��Left=�6"   $��
291,25,0,0q�6=   $	��Top=�6Q   $��29��6i   $��64��6u   $��1��6�   $��1��6�   �� 5"   
   -   5        $��Close��5"      $
��Left=�6!   $��
406,25,0,0q�6<   $	��Top=�6P   $��29��6h   $��64��6t   $��1��6�   $��1��6�   �� 5#   
   -   5        $ txtDescription��5#      $��1��6*   $
��Left=�6:   $��438,148,0,0q�6U   $
 Wrap=�6j   $��TextBox��6~   $	��Top=�6�   $	��187��6�   $��72��6�   5%      5&      