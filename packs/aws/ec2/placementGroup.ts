// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";

export class PlacementGroup extends lumi.NamedResource implements PlacementGroupArgs {
    public readonly _name: string;
    public readonly strategy: string;

    constructor(name: string, args: PlacementGroupArgs) {
        super(name);
        this._name = args._name;
        this.strategy = args.strategy;
    }
}

export interface PlacementGroupArgs {
    readonly _name: string;
    readonly strategy: string;
}
