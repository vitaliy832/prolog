edge(a, b).
edge(a, d).
edge(a, e).
edge(b, c).
edge(e, d).
edge(f, g).
connected(X,Y):-edge(X,Y).
connected(X,Y):-edge(X,Z), connected(Z,Y).
connected(X,Y):-edge(X,W),edge(W,Z),edge(Z,Y).
