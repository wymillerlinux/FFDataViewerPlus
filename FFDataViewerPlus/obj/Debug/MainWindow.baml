   M S B A M L   `   `   `  ����K  GFFDataViewerPlus, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:FFDataViewerPlusFFDataViewerPlus  5   	   !    FFDataViewerPlus.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:FFDataViewerPlus     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
dataGridFF��5
      $��Center=�6'   $	��265��6D   $��
10,75,10,0q�6Q   $	��Top=�6e   $	��772��6}   5      �� 5   
   -   5         ��Name$ 
btn_delete��5      $��Delete��6%   $
��Left=�66   $��
10,345,0,0q�6Q   $	��Top=�6e   $��75��6}   �� 5   
   -   5        $ btn_viewdetail��5      $��Details��6)   $
��Left=�6;   $��
90,345,0,0q�6V   $	��Top=�6j   $��75��6�    J� RenderTransformOrigin$ 0.434,1.901&�6�   6�   �� 5   
   -   5        $ 
btn_filter��5      $��Filter��6%   $
��Left=�66   $��170,345,0,0q�6Q   $	��Top=�6f   $��75��6~   $ 0.054,0.256&�6�   6�   �� 5   
   -   5        $ btn_help��5      $
��Help��6#   $
��Left=�62   $��627,345,0,0q�6M   $	��Top=�6b   $��75��6z   $��52��6�   6�   �� 5   
   -   5        $ btn_exit��5      $
��Exit��6#   $
��Left=�62   $��707,345,0,0q�6M   $	��Top=�6b   $��75��6z   $��52��6�   �� 5   
   -   5        $ 
btn_search��5      $��Search��6%   $
��Left=�66   $��
10,373,0,0q�6Q   $	��Top=�6e   $��75��6}   $��24��6�   6�   �� 5   
   -   5         ��Name$ txtbox_box1��5      $
��Left=�6'   $��23��6B   $��
90,373,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��235��6�   �� 5   
   -	   5         ��Name$ 	lbl_title��5      $��Final Fantasy Data Viewer��6#   $
��Left=�6G   $��	10,12,0,0q�6b   $��0,0,0,0q�6u   $	��Top=�6�   $	��772��6�   $��36(�6�   5      5      