# *** WARNING: this file was generated by the Pulumi Kubernetes codegen tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
from copy import copy
from typing import Optional

import pulumi
import pulumi.runtime
from pulumi import Input, ResourceOptions

from ... import tables, version


class RuntimeClass(pulumi.CustomResource):
    """
    RuntimeClass defines a class of container runtime supported in the cluster. The RuntimeClass is
    used to determine which container runtime is used to run all containers in a pod. RuntimeClasses
    are (currently) manually defined by a user or cluster provisioner, and referenced in the
    PodSpec. The Kubelet is responsible for resolving the RuntimeClassName reference before running
    the pod.  For more details, see https://git.k8s.io/enhancements/keps/sig-node/runtime-class.md
    """

    def __init__(self, resource_name, opts=None, handler=None, metadata=None, __name__=None, __opts__=None):
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if not resource_name:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(resource_name, str):
            raise TypeError('Expected resource name to be a string')
        if opts and not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        __props__['apiVersion'] = 'node.k8s.io/v1beta1'
        __props__['kind'] = 'RuntimeClass'
        if handler is None:
            raise TypeError('Missing required property handler')
        __props__['handler'] = handler
        __props__['metadata'] = metadata

        if opts is None:
            opts = pulumi.ResourceOptions()
        if opts.version is None:
            opts.version = version.get_version()

        super(RuntimeClass, self).__init__(
            "kubernetes:node.k8s.io/v1beta1:RuntimeClass",
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(name: str, id: Input[str], opts: Optional[ResourceOptions] = None):
        opts = ResourceOptions(id=id) if opts is None else opts.merge(ResourceOptions(id=id))
        return RuntimeClass(name, opts)

    def translate_output_property(self, prop: str) -> str:
        return tables._CASING_FORWARD_TABLE.get(prop) or prop

    def translate_input_property(self, prop: str) -> str:
        return tables._CASING_BACKWARD_TABLE.get(prop) or prop
