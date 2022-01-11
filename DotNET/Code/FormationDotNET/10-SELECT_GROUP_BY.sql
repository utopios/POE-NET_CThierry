-- D'abord, nous devons comprendre ce que sont les fonctions d'agrégation :
--    Sum: la fonction calcule la somme sur un ensemble d'enregistrements
--    Avg: la fonction calcule la moyenne sur un ensemble d'enregistrements
--    Count: la fonction compte le nombre d'enregistrement 
--    Min: la fonction récupère la valeur minumum
--    Max: la fonction récupère la valeur maximum
-- Ce sont les fonctions d'agrégation courantes. Tous ces fonctions prennent tout leur sens lorsqu'elles sont utilisées avec la commande Group by.

-- Affichage de la table ACCOUNT
SELECT Acc.ACCOUNT_ID,
		Acc.PRODUCT_CD,
		Acc.AVAIL_BALANCE,
		Acc.PENDING_BALANCE
FROM ACCOUNT Acc



SELECT Acc.PRODUCT_CD,
		Count(Acc.PRODUCT_CD) AS NbComptes,
		Sum(Acc.AVAIL_BALANCE) AS SommeMontant,
		Avg(Acc.AVAIL_BALANCE) As MoyenneComptes
FROM ACCOUNT Acc
GROUP BY Acc.PRODUCT_CD