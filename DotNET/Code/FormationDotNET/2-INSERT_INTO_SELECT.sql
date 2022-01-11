-- Affichage de la table ACC_TRANSACTION
SELECT * FROM ACC_TRANSACTION

-- Affichage de la table ACCount
SELECT * FROM ACCOUNT

-- Insertion multiple dans la table ACC_TRANSACTION
-- Utilisation d'un SELECT pour fournir les données à inserrer
-- La clé primaire est autogénéré (Auto increment) TXN_ID
INSERT INTO ACC_TRANSACTION
			(TXN_DATE,
			ACCOUNT_ID,
			TXN_TYPE_CD,
			AMOUNT,
			FUNDS_AVAIL_DATE
			)
SELECT Acc.OPEN_DATE,
		Acc.ACCOUNT_ID,
		'CDT',
		Acc.AVAIL_BALANCE,
		Acc.OPEN_DATE
FROM ACCOUNT Acc
WHERE ACC.PRODUCT_CD ='CD'