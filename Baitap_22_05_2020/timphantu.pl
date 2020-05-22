%tim phan tu dau tien
timptthunhat([Dau|_],Dau).
%tim phan tu thu 2
timptthuhai([_,Y|_],Y).
%tim phan tu cuoi
timptcuoi([X],X).
timptcuoi([_|Duoi],Kq):-timptcuoi(Duoi,Kq),!.
%lay phan tu dau trung voi X
layphantudau([X],X).
layphantudau([X|Duoi],X,Duoi):-!.
layphantudau([Dau|Duoi],X,[Dau|Kq]):-layphantudau(Duoi,X,Kq).
%lay ra cac phan tu trung voi X
layracacpt([],_,[]).
layracacpt([X|Duoi],X,Kq):-layracacpt(Duoi,X,Kq),!.
layracacpt([Dau|Duoi],X,[Dau|Kq]):-layracacpt(Duoi,X,Kq).
%xuat cac cap phan tu ke tiep nhau trong danh sach
xuatcacptketiepnhau([]).
xuatcacptketiepnhau([X,Y|Duoi]):-write(X,"-",Y),
	xuatcacptketiepnhau([Y|Duoi]).
%xuat danh  sach phan tu lay tu vi tri chan
ptovitrichan([],[]).
ptovitrichan([_],[]).
ptovitrichan([_,Chan|Duoi],[Chan|Kq]):-ptovitrichan(Duoi,Kq),!.
%dao nguoc trat tu
ptovitrichandao([],Phu,Phu).
ptovitrichandao([_],Phu,Phu).
ptovitrichandao([_,Chan|Duoi],Phu,Kq):-PhuMoi=[Chan|Phu],ptovitrichandao(Duoi,PhuMoi,Kq),!.
% xuat cac danh sach ma cac phan tu la can bac 2 cua cac phan tu tuong
% ung trong danh sach cac so cho truoc
dscanbachai([],[]).
dscanbachai([Dau|Duoi],[Socanbachai|Kq]):-Socanbachai=sqrt(Dau),
	dscanbachai(Duoi,Kq),!.

