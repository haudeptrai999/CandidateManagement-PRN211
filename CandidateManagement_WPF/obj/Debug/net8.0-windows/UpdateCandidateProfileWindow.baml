   M S B A M L   `   `   `  ����R  NCandidateManagement_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:CandidateManagement_WPFCandidateManagement_WPF  5   	   :    4CandidateManagement_WPF.UpdateCandidateProfileWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:CandidateManagement_WPF     5   	   -   5          � Title$"  UpdateCandidateProfileWindow��5   	   $	��531��6.   $	��300��6;    � WindowStyle$
 None=�6G    � 
ResizeMode$ NoResize=�6Z   
������  � AllowsTransparency$
 True��6�    � WindowStartupLocation$ CenterScreen=�6�   .��5	      �� ���#454545 �� CornerRadius$ 12��6"   
�������$��1q�6H   ._�5
   
   � .+�5      �� -   5        $��Close��5      $
��Left=�6%   $��223,481,0,0q�6@   $	��Top=�6U   $��38��6m   $��65��6y   6�   �� 5      -   5        $��Update��5      $
��Left=�6&   $��149,481,0,0q�6A   $	��Top=�6V   $��38��6n   $��65��6z   6�   �� 5      $��Update Candidate Profile��6   $��Center=�67   $	��Top=�6T   $	��280��6l   
�������$��20(�6�   $��Center=�6�   $��SemiBold"�6�   $��39��6�   $��0,10,0,0q�6�   �� 5      $��	Full Name��6   $
��Left=�6(   $��	30,89,0,0q�6C   $	��Top=�6V   $��87��6n   
�������$��15(�6�   �� 5      -   5         ��Name$ txtFullName��5      $��Center=�6+   $��	0,124,0,0q�6H    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $	��215��6�   $��29��6�   �� 5      $��	Birth Day��6   $
��Left=�6(   $��
29,158,0,0q�6C   $	��Top=�6W   $��87��6o   
�������$��15(�6�   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ 
dpBirthDay��5      $��Center=�6-   $��	0,193,0,0q�6J   $	��Top=�6]   $	��216��6u   $��24��6�   �� 5      $��Profile Short Description��6   $
��Left=�68   $��
30,222,0,0q�6S   $	��Top=�6g   $	��172��6   
�������$��15(�6�   �� 5      -   5        $ txtDescription��5      $��Center=�6.   $��	0,257,0,0q�6K   $
 Wrap=�6^   $	��Top=�6r   $	��216��6�   $��63��6�   �� 5      $��Profile URL��6   $
��Left=�6*   $��
30,325,0,0q�6E   $	��Top=�6Y   $	��172��6q   
�������$��15(�6�   �� 5      -   5        $ txtProfileUrl��5      $��Center=�6-   $��	0,360,0,0q�6J   $
 Wrap=�6]   $	��Top=�6q   $	��216��6�   $��29��6�   �� 5      $��Job Posting��6   $
��Left=�6*   $��
29,394,0,0q�6E   $	��Top=�6Y   $��87��6q   
�������$��15(�6�   �� 5      -   5        	 ��Name$	 	cmbPostID��5      $��Center=�6*   $��	0,429,0,0q�6G   $	��Top=�6Z   $	��216��6r   $��31��6~   �� 5      -	   5        
 ��Name$
 txtCandidateID��5   $   $��ID : ��6   $��Center=�6<   $	��Top=�6Y   $	��216��6q   
�������$��15(�6�   $��Center=�6�   $��SemiBold"�6�   $��35��6�   $��0,54,0,0q�6�   5      5      5      