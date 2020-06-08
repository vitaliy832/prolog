prostoe(X,X).
prostoe(X,I):-T is X mod I,T > 0,I2 is I+1,prostoe(X,I2).


deliteli(H,C):-deliteli2(H,T,2,C).

deliteli2(H,T,H,C):-C=T.
deliteli2(H,T,I,C):-M is H mod I,M = 0,prostoe(I,2),append(T,[I],T2),I2 is I + 1,deliteli2(H,T2,I2,C).

deliteli2(H,T,I,C):-I2 is I+1,deliteli2(H,T,I2,C).

pr([],K,Y):-Y = K.
pr([H|T],K,Y):-deliteli(H,C),append(C,K,K2),pr(T,K2,Y).


udal([],[]).
udal([H|T],[H|Y]):-udal2(H,T,R),!,udal(R,Y).
udal2(_,[],[]).
udal2(H,[H|T],R):-!,udal2(H,T,R).
udal2(H,[X|T],[X|R]):-!,udal2(H,T,R).

del(A):-pr(A,[],Y),udal(Y,X),write(X).

