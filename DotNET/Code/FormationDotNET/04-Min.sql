-- La fonction Min() permet de retourner la plus petite valeur d'une colonne
select * from Account

-- Selection de la valeur minimale de la table ACCOUNT
SELECT Min(Acc.AVAIL_BALANCE) AS SoldeMin
FROM ACCOUNT Acc


-- Selection de la valeur minimale pour les comptes épargnes de la table ACCOUNT
SELECT Min(Acc.AVAIL_BALANCE) AS SoldeMin
FROM ACCOUNT Acc
WHERE Acc.PRODUCT_CD='SAV'

-- EN utilisant GROUP BY
-- LEs comptes sont dans plusieurs agence
-- Rechercher la valeur minimale d'es comptes pour chaque agence
SELECT Acc.OPEN_BRANCH_ID,
		Min(Acc.AVAIL_BALANCE) AS SoldeMin
FROM ACCOUNT Acc
GROUP BY Acc.OPEN_BRANCH_ID
