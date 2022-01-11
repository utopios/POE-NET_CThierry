-- Recup�ration de l'ensemble des valeurs pr�sentes
SELECT * 
FROM PRODUCT pro

-- Requ�te sur la table PRODUCT avec des criteres de s�l�ction
SELECT * 
FROM PRODUCT Pro
WHERE Pro.PRODUCT_TYPE_CD = 'LOAN'

SELECT * 
FROM PRODUCT Pro
WHERE Pro.PRODUCT_TYPE_CD = 'ACCOUNT'

-- Rechercher une entr�e pr�cise
SELECT Pro.PRODUCT_CD, Pro.NAME 
FROM PRODUCT Pro
WHERE Pro.NAME = 'auto loan'