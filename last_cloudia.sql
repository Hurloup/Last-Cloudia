-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : dim. 15 mai 2022 à 18:26
-- Version du serveur : 10.4.24-MariaDB
-- Version de PHP : 8.1.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `last cloudia`
--

-- --------------------------------------------------------

--
-- Structure de la table `ark`
--

CREATE TABLE `ark` (
  `idArk` int(11) NOT NULL,
  `nomArk` varchar(50) NOT NULL,
  `descArk` varchar(500) DEFAULT NULL,
  `actifArk` enum('Oui','Non') NOT NULL DEFAULT 'Non',
  `RareteArk` enum('R','SR','SSR','LR','UR') NOT NULL,
  `Collaboration ?` enum('Oui','Non') NOT NULL DEFAULT 'Non',
  `Notes` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `ark`
--

INSERT INTO `ark` (`idArk`, `nomArk`, `descArk`, `actifArk`, `RareteArk`, `Collaboration ?`, `Notes`) VALUES
(1, 'Beast Hunter', NULL, 'Oui', 'SR', 'Non', 'Utilisé pour farm grâce à son actif'),
(2, 'Great War of Ruin', NULL, 'Oui', 'UR', 'Non', 'Son actif rend SLukiel très puissante'),
(3, 'Amaterasu', 'Attaques d\'attribut Lumière +15%, anti Mort-Vivant sur les attaques. A chaque fois qu\'une magie de soin est utilisée, réduit les dégâts subis (max -20% au maximum, se réinitialise à chaque vague/Si vaincu). Dégâts de lumière maximum +2000. Récupération de PV par les compétences actives +2000', 'Oui', 'UR', 'Non', NULL),
(4, 'Council of Ten', 'Pour chaque type Soldat, Chevalier, Sorcier ou Sniper qu\'un allié vivant possède, dégâts +1%, dégât subis -1% (Max 10%, -10%). A l\'utilisation de l\'actif de l\'ark Council of Ten, utilisation maximum des capacités +1 durant la vague. Maximum de Dégâts +2000', 'Non', 'UR', 'Non', 'Utilisé pour cheese des boss grâce à l\'actif qui permet d\'avoir une utilisation de capacité supplémentaire. Cet effet est intéressant sur SRoland et SAlice'),
(5, 'Aldanian Warriors', NULL, 'Non', 'R', 'Non', NULL),
(6, 'Grand Bargain', NULL, 'Non', 'SR', 'Non', NULL),
(7, 'Automail Mechanic', NULL, 'Non', 'LR', 'Oui', 'Collaboration Fullmetal Alchemist'),
(8, 'Flammie & Vuscav', NULL, 'Non', 'LR', 'Oui', 'Collaboration Trial of Mana');

-- --------------------------------------------------------

--
-- Structure de la table `competence`
--

CREATE TABLE `competence` (
  `idComptence` int(11) NOT NULL,
  `nomCompetence` varchar(50) NOT NULL,
  `Description` varchar(500) NOT NULL,
  `Skill Cost` enum('Aucun','SC 1','SC 2','SC 3','SC 4','SC 5','SC 6','SC 7','SC 8','SC 9','SC 10','SC 11','SC 12','SC 13','SC 14','SC 15') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `competence`
--

INSERT INTO `competence` (`idComptence`, `nomCompetence`, `Description`, `Skill Cost`) VALUES
(1, 'HP UP', '+5% HP', 'SC 2'),
(2, 'HP UP II', '+8% HP', 'SC 3'),
(3, 'HP UP III', '+12% HP', 'SC 4'),
(4, 'HP UP MAX', '+20% HP', 'SC 5'),
(5, 'MP Up', '+5% MP', 'SC 1'),
(6, 'MP Up II', '+8% MP', 'SC 2'),
(7, 'MP Up III', '+12% MP', 'SC 2'),
(8, 'MP Up MAX', '+20% MP', 'SC 4'),
(9, 'Attack Up', '+2% STR', 'SC 1'),
(10, 'Attack Up II', '+5% STR', 'SC 2'),
(11, 'Attack Up III', '+8% STR', 'SC 3'),
(12, 'Attack Up MAX', '+15% STR', 'SC 6'),
(13, 'Defense Up', '+2% DEF', 'SC 1'),
(14, 'Defense Up II', '+5% DEF', 'SC 2'),
(15, 'Defense Up III', '+8% DEF', 'SC 3'),
(16, 'Defense Up MAX', '+15% DEF', 'SC 6'),
(17, 'Magic Up', '+2% INT', 'SC 1'),
(18, 'Magic Up II', '+5% INT', 'SC 2'),
(19, 'Magic Up III', '+8% MAG', 'SC 3'),
(20, 'Magic Up MAX', '+15% MAG', 'SC 6'),
(21, 'Magic Defense Up', '+2% MND', 'SC 1'),
(22, 'Magic Defense Up II', '+5% MND', 'SC 2'),
(23, 'Magic Defense Up III', '+8% MND', 'SC 3'),
(24, 'Magic Defense Up MAX', '+15% MND', 'SC 6'),
(25, 'Critical Up', '2% Critical Hit Rate', 'SC 2'),
(26, 'Critical Up II', '5% Critical Hit Rate', 'SC 3'),
(27, 'Critical Up III', '+8% Critical Hit Rate', 'SC 7'),
(28, 'Aim Vitals', '+30% Critical Damage', 'SC 4'),
(29, 'Proud Force', 'Critical Hits will heal HP', 'SC 4'),
(30, 'Guard', '10% chance to automatically Guard against Physical Attacks for -25% Damage Received.', 'SC 1'),
(31, 'Steel Guard', 'When Guard activates, -25% Damage Received.', 'SC 2'),
(32, 'Vigilance', '+10% chance to automatically Guard attacks.\r\n', 'SC 2'),
(33, 'Spell Guard', 'Enable automatic Guard to activate against Magic.', 'SC 4'),
(34, 'Heal Guard', 'When Guard activates, heal for each guarded hit.', 'SC 4'),
(35, 'Magic Guard', 'When Guard activates, heal 1 MP for each guarded hit.', 'SC 4'),
(36, 'Grand Guard', '+50% Guard Break Durability.', 'SC 4'),
(37, 'Royal Armor', '50% chance to receive a Critical Hit as a normal hit.', 'SC 8'),
(38, 'Illusion', '10% chance to evade Physical Attacks.', 'SC 5'),
(39, 'Counter', '10% chance to counter Physical Hits.\r\nThis counter deals +100% Counter Damage.', 'SC 6'),
(40, 'Counter Boost', '+35% Counter Damage.', 'SC 4'),
(41, 'Beast Killer', 'Regular Attacks will deal Effective Damage to Beast type enemies.', 'SC 3'),
(42, 'Beast Slayer', 'Physical Attacks will deal Effective Damage to Beast type enemies.', ''),
(43, 'Plant Killer', 'Regular Attacks will deal Effective Damage to Plant type enemies.', 'SC 3'),
(44, 'Plant Slayer', 'Physical Attacks will deal Effective Damage to Plant type enemies.', 'SC 8'),
(45, 'Insect Killer', 'Regular Attacks will deal Effective Damage to Insect type enemies.', 'SC 3'),
(46, 'Insect Slayer', 'Physical Attacks will deal Effective Damage to Insect type enemies.', 'SC 8'),
(47, 'Bird Killer', 'Regular Attacks will deal Effective Damage to Bird type enemies.', 'SC 3'),
(48, 'Bird Slayer', 'Physical Attacks will deal Effective Damage to Bird type enemies.', 'SC 8'),
(49, 'Creature Killer', 'Regular Attacks will deal Effective Damage to Creature type enemies.', 'SC 3'),
(50, 'Creature Slayer', 'Physical Attacks will deal Effective Damage to Creature type enemies.', 'SC 8'),
(51, 'Undead Killer', 'Regular Attacks will deal Effective Damage to Undead type enemies.', 'SC 3'),
(52, 'Undead Slayer', 'Physical Attacks will deal Effective Damage to Undead type enemies.', 'SC 8'),
(53, 'Stone Killer', 'Regular Attacks will deal Effective Damage to Stone type enemies.', 'SC 3'),
(54, 'Stone Slayer', 'Physical Attacks will deal Effective Damage to Stone type enemies.', 'SC 8'),
(55, 'Machine Killer', 'Regular Attacks will deal Effective Damage to Machine type enemies.', 'SC 3'),
(56, 'Machine Slayer', 'Physical Attacks will deal Effective Damage to Machine type enemies.', 'SC 8'),
(57, 'Fish Killer', 'Regular Attacks will deal Effective Damage to Fish type enemies.', 'SC 3'),
(58, 'Fish Slayer', 'Physical Attacks will deal Effective Damage to Fish type enemies.', 'SC 8'),
(59, 'Spirit Killer', 'Regular Attacks will deal Effective Damage to Fish type enemies.', 'SC 3'),
(60, 'Spirit Slayer', 'Physical Attacks will deal Effective Damage to Spirit type enemies.', 'SC 8'),
(61, 'Dragon Killer', 'Regular Attacks will deal Effective Damage to Dragon type enemies.', 'SC 3'),
(62, 'Dragon Slayer', 'Physical Attacks will deal Effective Damage to Dragon type enemies.', 'SC 8'),
(63, 'God Killer', 'Regular Attacks will deal Effective Damage to God type enemies.', 'SC 3'),
(64, 'God Slayer', 'Physical Attacks will deal Effective Damage to God type enemies.', 'SC 8'),
(65, 'Soldier Killer', 'Regular Attacks will deal Effective Damage to Soldier type enemies.', 'SC 3'),
(66, 'Soldier Slayer', 'Physical Attacks will deal Effective Damage to Soldier type enemies.', 'SC 8'),
(67, 'Knight Killer', 'Regular Attacks will deal Effective Damage to Knight type enemies.', 'SC 3'),
(68, 'Knight Slayer', 'Physical Attacks will deal Effective Damage to Knight type enemies.', 'SC 8'),
(69, 'Sniper Killer', 'Regular Attacks will deal Effective Damage to Sniper type enemies.', 'SC 3'),
(70, 'Sniper Slayer', 'Physical Attacks will deal Effective Damage to Sniper type enemies.', 'SC 8'),
(71, 'Sorcerer Killer', 'Regular Attacks will deal Effective Damage to Sorcerer type enemies.', 'SC 3'),
(72, 'Sorcerer Slayer', 'Physical Attacks will deal Effective Damage to Sorcerer type enemies.', 'SC 8'),
(73, 'Fire Attack Raise', '+20% Damage for all Fire attacks.\r\n', 'SC 11'),
(74, 'Ice Attack Raise', '+20% Damage for all Ice attacks.\r\n', 'SC 11'),
(75, 'Earth Attack Raise', '+20% Damage for all Earth attacks.\r\n', 'SC 11'),
(76, 'Thunder Attack Raise', '+20% Damage for all Thunder attacks.\r\n', 'SC 11'),
(77, 'Light Attack Raise', '+20% Damage for all Light attacks.\r\n', 'SC 11'),
(78, 'Dark Attack Raise', '+20% Damage for all Dark attacks.\r\n', 'SC 11'),
(79, 'Sword Equip', 'Allow Swords to be equipped.', 'SC 2'),
(80, 'Axe Equip', 'Allow Axes to be equipped.', 'SC 2'),
(81, 'Spear Equip', 'Allow Spears to be equipped.', 'SC 2'),
(82, 'Hammer Equip', 'Allow Hammers to be equipped.', 'SC 2'),
(83, 'Bow Equip', 'Allow Bows to be equipped.', 'SC 2'),
(84, 'Machine Equip', 'Allow Machines to be equipped.', 'SC 2'),
(85, 'Claw Equip', 'Allow Claws to be equipped.', 'SC 2'),
(86, 'Staff Equip', 'Allow Staffs to be equipped.', 'SC 2'),
(87, 'Armor Equip', 'Allow Armors to be equipped.', 'SC 2'),
(88, 'Clothes Equip', 'Allow Clothes to be equipped.', 'SC 2'),
(89, 'Robe Equip', 'Allow Robes to be equipped.', 'SC 2'),
(90, 'Poison Resist', '+1 Poison Resistance.\r\n', 'SC 4'),
(91, 'Poison Nil', '+2 Poison Resistance.\r\n', 'SC 8'),
(92, 'Blind Resist', '+1 Blind Resistance.\r\n', 'SC 4'),
(93, 'Blind Nil', '+2 Blind Resistance.\r\n', 'SC 8'),
(94, 'Silence Resist', '+1 Silence Resistance.\r\n', 'SC 4'),
(95, 'Silence NIl', '+2 Silence Resistance.', 'SC 8'),
(96, 'Curse Resist', '+1 Curse Resistance.', 'SC 4'),
(97, 'Curse Nil', '+2 Curse Resistance', 'SC 8'),
(98, 'Stun Resist', '+1 Stun Resistance', 'SC 5'),
(99, 'Stun Nil', '+2 Stun Resistance', 'SC 10'),
(100, 'Illness Resist', '+1 Illness Resistance', 'SC 5'),
(101, 'Illness Nil', '+2 Illness Resistance', 'SC 10'),
(102, 'Fast Brave', 'Wave Start: Grant a +20% STR for 40s buff to self.', 'SC 2'),
(103, 'Fast Aura', 'Wave Start: Grant a +20% INT for 40s buff to self.', 'SC 2'),
(104, 'Fast Protection', 'Wave Start: Grant a -20% Physical Damage Received for 40s buff to self.\r\n', 'SC 2'),
(105, 'Fast Magic Barrier', 'Wave Start: Grant a -20% Magical Damage Received for 40s buff to self.\r\n', 'SC 2'),
(106, 'Auto Brave', 'Wave Start: Grant a permanent STR buff to self.\r\n', 'SC 7'),
(107, 'Auto Protection', 'Wave Start: Grant a permanent -20% Physical Damage Received to self.\r\n', 'SC 7'),
(108, 'Auto Aura', 'Wave Start: Grant a permanent INT buff to self.\r\n', 'SC 7'),
(109, 'Auto Magic Barrier', 'Wave Start: Grant a permanent -20% Magical Damage Received to self.\r\n', 'SC 7'),
(110, 'Auto Regeneration', 'Wave Start: Grant a permanent buff to self. Regenerate a large amount of HP every 6s', 'SC 11'),
(111, 'Auto Haste', 'Wave Start: Grant a permanent +25% Skill Charging Speed buff to self.', 'SC 14');

-- --------------------------------------------------------

--
-- Structure de la table `competencesark`
--

CREATE TABLE `competencesark` (
  `idArk` int(11) NOT NULL,
  `idComptence` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `competencesark`
--

INSERT INTO `competencesark` (`idArk`, `idComptence`) VALUES
(5, 1),
(6, 2),
(7, 2),
(8, 2);

-- --------------------------------------------------------

--
-- Structure de la table `competencespersonnage`
--

CREATE TABLE `competencespersonnage` (
  `idPerso` int(11) NOT NULL,
  `idComptence` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `competencespersonnage`
--

INSERT INTO `competencespersonnage` (`idPerso`, `idComptence`) VALUES
(1, 9),
(1, 29),
(1, 64),
(1, 102),
(2, 26),
(2, 27),
(2, 49),
(2, 76),
(3, 48),
(4, 26),
(4, 29),
(4, 74),
(5, 8),
(5, 22),
(5, 110),
(6, 26),
(6, 27),
(6, 29),
(6, 37),
(6, 73),
(6, 107),
(6, 111),
(7, 27),
(7, 28),
(7, 39),
(7, 76),
(7, 111),
(8, 27),
(8, 28),
(8, 110),
(8, 111),
(9, 26),
(9, 29),
(9, 74),
(10, 26),
(10, 27),
(10, 37),
(10, 107),
(11, 6),
(11, 7),
(11, 18),
(11, 20),
(11, 94),
(12, 24);

-- --------------------------------------------------------

--
-- Structure de la table `personnage`
--

CREATE TABLE `personnage` (
  `idPerso` int(11) NOT NULL,
  `nomPerso` varchar(50) NOT NULL,
  `DescriptionPerso` varchar(255) DEFAULT NULL,
  `Collaboration ?` enum('Oui','Non') NOT NULL DEFAULT 'Non',
  `Notes` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `personnage`
--

INSERT INTO `personnage` (`idPerso`, `nomPerso`, `DescriptionPerso`, `Collaboration ?`, `Notes`) VALUES
(1, 'Kyle the Swordsman', 'Personnage principal du jeux. A une autre version, Knight Lord Kyle', 'Non', ''),
(2, 'Magic Beast Rei', 'Personnage principal du jeux. A une autre version, Divine Beast Rei', 'Non', ''),
(3, 'Lilebette of the Blaze', 'Personnage principal du jeux. A d\'autres versions, Swordmagineer Lilebette et Saintly Lilebette', 'Non', ''),
(4, 'Ice General Zekus', 'Personnage principal du jeux. A une autre version, Sage Emperor Zekus', 'Non', ''),
(5, 'Mysterious Girl Theria', 'Personnage principal du jeux. A d\'autres versions, Saintly Theria et Spirit Maiden Theria', 'Non', ''),
(6, 'Knight Lord Kyle', 'Personnage principal du jeux. A une autre version, Kyle the Swordsman\r\n', 'Non', 'Aussi appelé KLKyle ou SKyle'),
(7, 'Divine Beast Rei', 'Personnage principal du jeux. A une autre version, Magic Beast Rei\r\n\r\n', 'Non', 'Aussi appelé DBRei et SRei'),
(8, 'Swordmagineer Lilebette', 'Personnage principal du jeux. A d\'autres versions, Lilebette of the Blaze et Saintly Lilebette', 'Non', 'Aussi appelée Sbette ou SLile'),
(9, 'Saintly Lilebette', 'Personnage principal du jeux. A d\'autres versions, Lilebette of the Blaze et Swordmagineer Lilebette', 'Non', 'Aussi appelée Xbette'),
(10, 'Sage Emperor Zekus', 'Personnage principal du jeux. A une autre version, Ice General Zekus', 'Non', 'Aussi appelé SZekus'),
(11, 'Saintly Theria', 'Personnage principal du jeux. A d\'autres versions, Mysterious Girl Theria et Spirit Maiden Theria\r\n\r\n', 'Non', 'Aussi appelée XTheria'),
(12, 'Spirit Maiden Theria', 'Personnage principal du jeux. A d\'autres versions, Mysterious Girl Theria et Saintly Theria\r\n', 'Non', 'Aussi appelée SMTheria, STheria, MTheria');

-- --------------------------------------------------------

--
-- Doublure de structure pour la vue `v_arkcomp`
-- (Voir ci-dessous la vue réelle)
--
CREATE TABLE `v_arkcomp` (
`nomArk` varchar(50)
,`nomCompetence` varchar(50)
);

-- --------------------------------------------------------

--
-- Doublure de structure pour la vue `v_personnagecomp`
-- (Voir ci-dessous la vue réelle)
--
CREATE TABLE `v_personnagecomp` (
`nomPerso` varchar(50)
,`nomCompetence` varchar(50)
);

-- --------------------------------------------------------

--
-- Structure de la vue `v_arkcomp`
--
DROP TABLE IF EXISTS `v_arkcomp`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_arkcomp`  AS SELECT `ark`.`nomArk` AS `nomArk`, `competence`.`nomCompetence` AS `nomCompetence` FROM ((`ark` left join `competencesark` on(`competencesark`.`idArk` = `ark`.`idArk`)) left join `competence` on(`competence`.`idComptence` = `competencesark`.`idComptence`)) WHERE `competence`.`nomCompetence` is not null ORDER BY `ark`.`idArk` ASC  ;

-- --------------------------------------------------------

--
-- Structure de la vue `v_personnagecomp`
--
DROP TABLE IF EXISTS `v_personnagecomp`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `v_personnagecomp`  AS SELECT `personnage`.`nomPerso` AS `nomPerso`, `competence`.`nomCompetence` AS `nomCompetence` FROM ((`personnage` left join `competencespersonnage` on(`competencespersonnage`.`idPerso` = `personnage`.`idPerso`)) left join `competence` on(`competence`.`idComptence` = `competencespersonnage`.`idComptence`)) WHERE `competence`.`nomCompetence` is not null ORDER BY `personnage`.`idPerso` ASC  ;

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `ark`
--
ALTER TABLE `ark`
  ADD PRIMARY KEY (`idArk`);

--
-- Index pour la table `competence`
--
ALTER TABLE `competence`
  ADD PRIMARY KEY (`idComptence`);

--
-- Index pour la table `competencesark`
--
ALTER TABLE `competencesark`
  ADD PRIMARY KEY (`idArk`,`idComptence`),
  ADD KEY `Etre_disponible_Competence0_FK` (`idComptence`);

--
-- Index pour la table `competencespersonnage`
--
ALTER TABLE `competencespersonnage`
  ADD PRIMARY KEY (`idPerso`,`idComptence`),
  ADD KEY `Avoir_Competence0_FK` (`idComptence`);

--
-- Index pour la table `personnage`
--
ALTER TABLE `personnage`
  ADD PRIMARY KEY (`idPerso`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `ark`
--
ALTER TABLE `ark`
  MODIFY `idArk` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT pour la table `competence`
--
ALTER TABLE `competence`
  MODIFY `idComptence` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=112;

--
-- AUTO_INCREMENT pour la table `personnage`
--
ALTER TABLE `personnage`
  MODIFY `idPerso` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `competencesark`
--
ALTER TABLE `competencesark`
  ADD CONSTRAINT `Etre_disponible_Ark_FK` FOREIGN KEY (`idArk`) REFERENCES `ark` (`idArk`),
  ADD CONSTRAINT `Etre_disponible_Competence0_FK` FOREIGN KEY (`idComptence`) REFERENCES `competence` (`idComptence`);

--
-- Contraintes pour la table `competencespersonnage`
--
ALTER TABLE `competencespersonnage`
  ADD CONSTRAINT `Avoir_Competence0_FK` FOREIGN KEY (`idComptence`) REFERENCES `competence` (`idComptence`),
  ADD CONSTRAINT `Avoir_Personnage_FK` FOREIGN KEY (`idPerso`) REFERENCES `personnage` (`idPerso`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
