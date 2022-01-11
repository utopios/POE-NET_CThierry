-- La condition Having permet d'indiquer les conditions de séléction afin filtrer les groupe de résultats
-- La commande WHERE met en oeuvre des conditions sur nos colonnes, alors que Having permet d'appliquer 
-- des conditions sur des groupes qui sont crés par la commande Group By
SELECT * FROM ACCOUNT
-- Requête pour regrouper les catégories de service et n'avoir que les membres ayant plus de 3 entrées
-- Sans La condition Having
SELECT Acc.PRODUCT_CD,
		Count(Acc.PRODUCT_CD) AS NbComptes,
		Sum(Acc.AVAIL_BALANCE) AS SommeMontant,
		Avg(Acc.AVAIL_BALANCE) As MoyenneMontant
FROM ACCOUNT Acc
GROUP BY Acc.PRODUCT_CD

-- Avec La condition Having (garde que les membres ayant 3 entres ou plus)
SELECT Acc.PRODUCT_CD,
		Count(Acc.PRODUCT_CD) AS NbComptes,
		Sum(Acc.AVAIL_BALANCE) AS SommeMontant,
		Avg(Acc.AVAIL_BALANCE) As MoyenneMontant
FROM ACCOUNT Acc
GROUP BY Acc.PRODUCT_CD
HAVING count(Acc.PRODUCT_CD) > 3

-- La distinction entre WHERE ET HAVING :
	-- WHERE est utilisé pour filtrer la BDD avant le regoupement par GROUP BY
	-- HAVING est utilisé pour filtrer la BDD après le regoupement par GROUP BY

-- Requete pour des informations d'une succursale en particulier (OPEN_BRANCH_ID =1)
SELECT Acc.ACCOUNT_ID,
		Acc.PRODUCT_CD,
		Acc.OPEN_BRANCH_ID,
		Acc.AVAIL_BALANCE
FROM ACCOUNT Acc
-- Utilisation du WHERE avant le regroupement par GROUP BY
WHERE Acc.OPEN_BRANCH_ID = 1


SELECT Acc.PRODUCT_CD,
		Count(Acc.PRODUCT_CD) AS NbComptes,
		Sum(Acc.AVAIL_BALANCE) AS SommeMontant,
		Avg(Acc.AVAIL_BALANCE) As MoyenneMontant
FROM ACCOUNT Acc
WHERE Acc.OPEN_BRANCH_ID = 1
GROUP BY Acc.PRODUCT_CD

SELECT Acc.PRODUCT_CD,
		Count(Acc.PRODUCT_CD) AS NbComptes,
		Sum(Acc.AVAIL_BALANCE) AS SommeMontant,
		Avg(Acc.AVAIL_BALANCE) As MoyenneMontant
FROM ACCOUNT Acc
WHERE Acc.OPEN_BRANCH_ID = 1
GROUP BY Acc.PRODUCT_CD
HAVING Count(Acc.PRODUCT_CD) >1