   M S B A M L   `   `   `  ����?  ;POD7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:POD7POD7  5          POD7.Dokumentacja   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $localclr-namespace:POD7     5        N� Title$  Dokumentacja��5	      .��5      � $��0,0,-202,-202q�6   ���	#FF323232.+�5   
   �� -   5         ��Name$ label��5      $��Dokumentacja��6   $
��Left=�66   $��
172,29,0,0q�6Q   $	��Top=�6e   
�������$��22(�6�   $
��Bold"�6�   �� 5   
   -   5        $ label1��5      $����Testy statystyczne  wg FIPS 140-2 - test pojedynczych bitów, test serii, test długiej serii i
test pokerowy.

string testPojedynczychBitow() - Jeżeli liczba jedynek jest większa od 9725 i mniejsza od
10275 to test zakończy się sukcesem

string testSerii() - Test powiedzie się sukcesem jeżeli liczność serii jedynek i zer o długości
1-6 i wiecej zawiera się w przedziałach.
			1		2315-2685
			2		1114-1386
			3		527-723
			4		240-384
			5		103-209
			6 i więcej	103-209
string testDlugiejSerii() - Test zakończy se sukcesem jeżeli nie występuje seria długa,
czyli seria, która jest dłuższa od 26.

string testPokerowy() - Test zakończy sie sukcesem jeżeli 2,16<X<46,17, gdzie 
X=16/5000*Σ(s(i))^2-5000, gdzie 0<=i<=15, s(i) - liczność segmentów 4-bitowych.

Odczyt odbywa się do pliku C:\Users\Public\Key.txt, a zapis do Result.txt.

Wykonano za pomocą Visual Studio 2017 w języku C#
Autor: Agnieszka Gregulec��6    $
��Left=�6�  $��	10,73,0,0q�6  $	��Top=�6&  
�������$	��482��6Q  $	��419��6]  5      5      