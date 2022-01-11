-- Recup�ration de l'ensemble des valeures pr�sentes
SELECT * FROM PRODUCT

-- SELECT en pr�cisant les colonnes
SELECT Pro.PRODUCT_CD,
		Pro.NAME,
		Pro.PRODUCT_TYPE_CD
FROM PRODUCT Pro

-- SELECT pour isoler la colonne PRODUCT_TYPE_CD
SELECT Pro.PRODUCT_TYPE_CD
FROM PRODUCT Pro

--SELECT DISTINCT

-- Selection Distincte afin de supprimer les doublons
SELECT DISTINCT Pro.PRODUCT_TYPE_CD
FROM PRODUCT Pro