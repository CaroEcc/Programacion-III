   M S B A M L   `   `   `  ����N  JExpresionesLambda_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ExpresionesLambda_1ExpresionesLambda_1  5   	   $    ExpresionesLambda_1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ExpresionesLambda_1     5   	     � Title$  
MainWindow��5   	   $��391.906��6   $��547.936��6-   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��18* �6   �� 5      .+�5   
   �� $��REGISTRO ESTUDIANTE��6   $
��Bold"�6.   $
��Left=�6@   $��	63,70,0,0q�6[   $	��Top=�6n   $��38��6�   $	��148��6�   �� 5   
   -   5         ��Name$ 	txtNombre��5      $
��Left=�6%   $��34��6@   $��
51,113,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��160��6�   �� 5   
   -   5        $ txtNota��5      $
��Left=�6#   $��35��6>   $��
51,172,0,0q�6J   $
 Wrap=�6^   $	��Top=�6s   $	��160��6�   �� 5   
   -   5         ��Name$ btnEnvio��5      $��ENVIAR��6#   $
��Left=�64   $��
51,229,0,0q�6O   $	��Top=�6c   $	��160��6{   $��41��6�   6�   �� 5   
   -   5         ��Name$ 	lstLista1��5      $
��Left=�6%   $��66��6@   $��
258,49,0,0q�6L   $	��Top=�6`   $	��259��6x   �� 5   
   $��Todos los estudiantes:��6   $
��Left=�61   $��
258,23,0,0q�6L   $	��Top=�6`   �� 5   
   -   5        $ 	lstLista2��5      $
��Left=�6%   $��66��6@   $��258,153,0,0q�6L   $	��Top=�6a   $	��259��6y   �� 5   
   $&�� Estudiantes con nota mayor a 51:��6   $
��Left=�6;   $��258,127,0,0q�6V   $	��Top=�6k   �� 5   
   -   5        $ 	lstLista3��5      $
��Left=�6%   $��66��6@   $��258,263,0,-24.2q�6L   $	��Top=�6e   $	��259��6}   $��2��6�   �� 5   
   $!��Estudiantes con nota de 50:��6   $
��Left=�66   $��258,237,0,0q�6Q   $	��Top=�6f   �� 5   
   -   5        $��IMPRIMIR��5      $
��Left=�6$   $��
51,275,0,0q�6?   $	��Top=�6S   $	��160��6k   $��43��6w   6�   5      5      