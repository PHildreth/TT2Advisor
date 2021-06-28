import React, { Component } from 'react';
import { PlayerStats } from './playerStats';
import { RaidStats } from './raidStats';
import { Artifacts } from './artifacts';
import { SplashStats } from './splashStats';
import { RaidCards } from './raidCards';
import { EquipmentSets } from './equipmentSets';
import { PassiveSkills } from './passiveSkills';
import { PetLevels } from './petLevels';
import { SkillTree } from './skillTree';

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
                <PlayerStats playerStats={myBuild.playerStats} />
                <RaidStats raidStats={myBuild.raidStats} />
                <Artifacts artifacts={myBuild.artifacts} />
                <SplashStats splashStats={myBuild.splashStats} />
                <RaidCards raidCards={myBuild.raidCards} />
                <EquipmentSets equipmentSets={myBuild.equipmentSets} />
                <PassiveSkills passiveSkills={myBuild.passiveSkills} />
                <PetLevels petLevels={myBuild.petLevels} />
                <SkillTree skillTree={myBuild.skillTree} />
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
