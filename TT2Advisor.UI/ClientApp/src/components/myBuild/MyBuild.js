import { fn } from 'jquery';
import React, { Component } from 'react';

export class MyBuild extends Component {
    static displayName = MyBuild.name;

    constructor(props) {
        super(props);
        this.state = { myBuild: null, loading: true };
    }

    componentDidMount() {
        this.populateMyBuild();
    }

    static renderMyBuild(myBuild) {
        return (
            <div>
                <div>
                    <h2>Player Stats</h2>
                    <table className='table table-striped' aria-labelledby="tabelLabel">
                        <thead>
                            <tr>
                                <th>Stat</th>
                                <th>Value</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>Max Prestige Stage</td>
                                <td>{myBuild.playerStats.maxPrestigeStage}</td>
                            </tr>
                            <tr>
                                <td>Artifacts Collected</td>
                                <td>{myBuild.playerStats.artifactsCollected}</td>
                            </tr>
                            <tr>
                                <td>Crafting Power</td>
                                <td>{myBuild.playerStats.craftingPower}</td>
                            </tr>
                            <tr>
                                <td>Total Pet Levels</td>
                                <td>{myBuild.playerStats.totalPetLevels}</td>
                            </tr>
                            <tr>
                                <td>Skill Points Owned</td>
                                <td>{myBuild.playerStats.skillPointsOwned}</td>
                            </tr>
                            <tr>
                                <td>Hero Weapon Upgrades</td>
                                <td>{myBuild.playerStats.heroWeaponUpgrades}</td>
                            </tr>
                            <tr>
                                <td>Hero Scroll Upgrades</td>
                                <td>{myBuild.playerStats.heroScrollUpgrades}</td>
                            </tr>
                            <tr>
                                <td>Tournaments Joined</td>
                                <td>{myBuild.playerStats.tournamentsJoined}</td>
                            </tr>
                            <tr>
                                <td>Undisputed Wins</td>
                                <td>{myBuild.playerStats.undisputedWins}</td>
                            </tr>
                            <tr>
                                <td>Tournament Points</td>
                                <td>{myBuild.playerStats.tournamentPoints}</td>
                            </tr>
                            <tr>
                                <td>Lifetime Relics</td>
                                <td>{myBuild.playerStats.lifetimeRelics}</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <div>
                    <h2>Raid Stats</h2>
                    <table className='table table-striped' aria-labelledby="tabelLabel">
                        <thead>
                            <tr>
                                <th>Stat</th>
                                <th>Value</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>Raid Level</td>
                                <td>{myBuild.raidStats.raidLevel}</td>
                            </tr>
                            <tr>
                                <td>Raid Damage</td>
                                <td>{myBuild.raidStats.raidDamage}</td>
                            </tr>
                            <tr>
                                <td>Total Raid Experience</td>
                                <td>{myBuild.raidStats.totalRaidExperience}</td>
                            </tr>
                            <tr>
                                <td>Total Raid Attacks</td>
                                <td>{myBuild.raidStats.totalRaidAttacks}</td>
                            </tr>
                            <tr>
                                <td>Total Raid Card Levels</td>
                                <td>{myBuild.raidStats.totalRaidCardLevels}</td>
                            </tr>
                            <tr>
                                <td>Raid Cards Owned</td>
                                <td>{myBuild.raidStats.raidCardsOwned}</td>
                            </tr>
                            <tr>
                                <td>Lifetime Clan Morale</td>
                                <td>{myBuild.raidStats.lifetimeClanMorale}</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <div>
                    <h2>Artifacts</h2>
                    <table className='table table-striped' aria-labelledby="tabelLabel">
                        <thead>
                            <tr>
                                <th>Stat</th>
                                <th>Value</th>
                            </tr>
                        </thead>
                        <tbody>
                            {
                                Object.keys(myBuild.artifacts).map((key, index) => {
                                    console.log({ k: key, v: myBuild.artifacts[key], i: index });
                                    return (
                                        <tr key={index}>
                                            <td>{myBuild.artifacts[key].friendlyName}</td>
                                            <td>{myBuild.artifacts[key].level}</td>
                                        </tr>
                                    );
                                })
                            }
                        </tbody>
                    </table>
                </div>
                <div>
                    <h2>Splash Stats</h2>
                    <table className='table table-striped' aria-labelledby="tabelLabel">
                        <thead>
                            <tr>
                                <th>Stat</th>
                                <th>Value</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>Splash Damage</td>
                                <td>{myBuild.splashStats.splashDamage}</td>
                            </tr>
                            <tr>
                                <td>Base Max Splash Count</td>
                                <td>{myBuild.splashStats.baseMaxSplashCount}</td>
                            </tr>
                            <tr>
                                <td>All Splash Skip</td>
                                <td>{myBuild.splashStats.allSplashSkip}</td>
                            </tr>
                            <tr>
                                <td>Heavenly Strike Splash Count</td>
                                <td>{myBuild.splashStats.heavenlyStrikeSplashCount}</td>
                            </tr>
                            <tr>
                                <td>Lightning Burst Splash Count</td>
                                <td>{myBuild.splashStats.lightningBurstSplashCount}</td>
                            </tr>
                            <tr>
                                <td>Clan Ship Splash Count</td>
                                <td>{myBuild.splashStats.clanShipSplashCount}</td>
                            </tr>
                            <tr>
                                <td>Dagger Splash Count</td>
                                <td>{myBuild.splashStats.daggerSplashCount}</td>
                            </tr>
                            <tr>
                                <td>Heavenly Strike Splash Skip</td>
                                <td>{myBuild.splashStats.heavenlyStrikeSplashSkip}</td>
                            </tr>
                            <tr>
                                <td>Pet Splash Skip</td>
                                <td>{myBuild.splashStats.petSplashSkip}</td>
                            </tr>
                            <tr>
                                <td>Clan Ship Splash Skip</td>
                                <td>{myBuild.splashStats.clanShipSplashSkip}</td>
                            </tr>
                            <tr>
                                <td>Shadow Clone Splash Skip</td>
                                <td>{myBuild.splashStats.shadowCloneSplashSkip}</td>
                            </tr>
                            <tr>
                                <td>Dagger Splash Skip</td>
                                <td>{myBuild.splashStats.daggerSplashSkip}</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        );
    }


    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : MyBuild.renderMyBuild(this.state.myBuild);

        return (
            <div>
                <h1 id="tabelLabel" >My Build</h1>
                <p>This component demonstrates fetching data from the server.</p>
                {contents}
            </div>
        );
    }

    async populateMyBuild() {
        const response = await fetch('myBuild');
        const data = await response.json();
        this.setState({ myBuild: data, loading: false });
        console.log("this.state.myBuild");
        console.log(this.state.myBuild);
    }
}
